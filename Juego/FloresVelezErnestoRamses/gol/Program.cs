using System;
using System.Collections.Generic;

namespace gol
{
    enum Estado { viva, vacia}
    class Celula {
        public Estado estado_actual;
        public Estado estado_siguiente;
        public Tablero tablero;
        public short renglon;
        public short columna;
        
        public void actualiza_estado(){
          short vecinas = num_vecinas();
			if(estado_actual == Estado.viva && (vecinas < 2 || vecinas > 3)) {
				estado_siguiente = Estado.vacia;
			}
			if(estado_actual == Estado.vacia && vecinas == 3) {
				estado_siguiente = Estado.viva;
			}
        }
        public Celula(Estado inicial, Tablero tablero ,   short renglon, short columna)
        {
            estado_actual = inicial;
            this.tablero = tablero;
            this.renglon = renglon;
            this.columna = columna;
        }

        public void estado_siguiente(){
           
             if (num_vecinas() == 1)
             {
               estado_siguiente = Estado.viva;
             }
        }

        public short num_vecinas()
        {   short cuenta = 0;
            // 1 
            if (renglon > 0  && columna > 0)

            return cuenta;
            if(renglon > 0) {
				if(columna > 0 && tablero.cell_in_pos(renglon-1, columna-1).estado_actual == Estado.viva)
					cuenta++;
				if(tablero.cell_in_pos(renglon-1, columna).estado_actual == Estado.viva)
					cuenta++;
				if(columna < tablero.num_columnas-1 && tablero.cell_in_pos(renglon-1, columna+1).estado_actual == Estado.viva)
					cuenta++;
			}

			// Renglon siguiente
			if(renglon < tablero.num_renglones-1)
			{
				if(columna > 0 && tablero.cell_in_pos(renglon+1, columna-1).estado_actual == Estado.viva)
					cuenta++;
				if(tablero.cell_in_pos(renglon+1, columna).estado_actual == Estado.viva)
					cuenta++;
				if(columna < tablero.num_columnas-1 && tablero.cell_in_pos(renglon+1, columna+1).estado_actual == Estado.viva)
					cuenta++;
			}
			return cuenta;
        } 

       
    public char symbol(){
		   if (this.estado_actual == Estado.vacia){
				return '▒';
		   } 
		   else 
		   {
				return '█';
		   }
			
		}
	}
    class Tablero {
        public List<List<Celula >> grid;
        public Tablero(short num_renglones, short num_columnas){
              grid = new List<List<Celula>>(); 
              for (short i=0; i<= num_renglones-1; i++)
              {
                 grid.Add(new List<Celula>()); 
                 for (short j = 0; j <= num_columnas-1; j++)
                 {
                    grid[i].Add(new Celula(Estado.vacia, this, i,j));
                 }
              }

        }
        public void actualizar_tablero(){
			foreach(List<Celula> renglon in grid)
			{
				foreach(Celula c in renglon)
				{
					c.actualiza_estado_siguiente();
				}
			}       
		}
		public void siguiente_turno(){
			foreach(List<Celula> renglon in grid)
			{
				foreach(Celula c in renglon)
				{
					c.actualiza_estado();
				}
			}
		}
		public void avanzar_turnos(int turnos, int ticks) {
			for(int i = 0; i < turnos; i++) {
				Console.Clear();
				print();
				actualizar_tablero();
				siguiente_turno();
				System.Threading.Thread.Sleep(ticks);
			}
		}
public void actualiza_estado_todas(){
  foreach(List<Celula> renglon in grid)
            {
               foreach(Celula c in renglon)
               {
                    c.actualiza_estado();
                }         
                Console.WriteLine("");
            }
         }
}

        public void inserta(Celula c){
            if((c.renglon >= 0 && c.renglon <= num_renglones) && (c.columna >= 0 && c.columna <= num_columnas))
                grid[c.renglon][c.columna] = c;
        }
        
		public Celula cell_in_pos(int renglon, int columna) {
			if(!(renglon >= 0 && renglon < num_renglones))
				throw new ArgumentException("El renglon especificado esta fuera del rango ("+renglon+", MAX "+num_renglones+") Params: ("+renglon+", "+columna+")", "renglon");
			else if(!(columna >= 0 && columna < num_columnas))
				throw new ArgumentException("La columna especificada esta fuera del rango ("+columna+", MAX "+num_columnas+") Params: ("+renglon+", "+columna+")", "columna");
			else
				return grid[renglon][columna];
		}

        public void print(bool show_directions = false){
            string buffer = "";
			if(show_directions)
				buffer+="   R\n   _\nC |";
            foreach(List<Celula> renglon in grid)
            {
                if(show_directions && grid.IndexOf(renglon) != 0)
					buffer+="   ";
               foreach(Celula c in renglon)
                {
                    buffer += c.symbol();
                    c.print();
                }    
            
                buffer+="\n";     
            }
                Console.WriteLine("buffer");
                           
        } 
    }


    class Program
{
        static void Main(string[] args)
        {
             Tablero GoL = new Tablero(10,5);
             GoL.inserta( new Celula(Estado.viva,GoL, 3,3  ) );
             GoL.inserta( new Celula(Estado.viva,GoL, 3,2  ) );
             GoL.inserta( new Celula(Estado.viva,GoL, 3,1  ) );
             GoL.inserta( new Celula(Estado.viva,GoL, 0,0  ) );
             
             GoL.print(); 
             Console.WriteLine(GoL.grid[1][1].num_vecinas());  
        }
    }
}