

package com.mycompany.batallanaval;

/**
 *
 * @author ebarrero
 */
import java.util.Scanner;

public class BatallaNaval {
static String[][] tablero = new String[11][11];
static Scanner sc = new Scanner(System.in);
static int posicion, longitud, coordenadaX, coordenadaY, coordenadaXA, coordenadaYA;

    public static void main(String[] args) {
      tablero();
      menu();
      
      
    }

    public static void menu() {
        System.out.println("\nTienes 10 oportunidades para adivinar la posición del barco. El barco va a estar ubicado en posición horizontal o vertical (0=Horizontal , 1=vertical)");
        seleccionPosicion();
        System.out.println("Cuál será la longitud del barco: de 3 ó 4 posiciones");
        seleccionLongitud();
        System.out.println("\nDónde empezará el barco, ingrese la coordenada de la forma (x,y)");
        seleccionCoordenadaInicial();  
        System.out.println("Dónde puede estar el barco, ingrese la coordenada de la forma (x,y)");
        seleccionCoordenadaAtaque();
        menu2();
    }
    public static void menu2(){ //soy un maldito perezoso, sorry
        for (int i = 0; i < 10; i++) {
        System.out.println("\nDónde puede estar el barco, ingrese la coordenada de la forma (x,y)");
        seleccionCoordenadaAtaque();    
        }
        
        
    
    }

    public static void tablero() {
        
        for (int i = 0; i < 11; i++) {
            for (int j = 0; j < 11; j++) {
                tablero[0][j] = "Y" + j;
                tablero[i][0] = "X" + i;
                tablero[i][j] = "~";
                
            }
        }
        for (int i = 0; i < 11; i++) {
            for (int j = 0; j < 11; j++) {
           System.out.printf("%-7s", tablero[i][j]);
         
           }
            
            System.out.println("");
        }
    }
    
    public static void tableroActualizacion() {
       // Este es el código de ChatGPT
        for (int i = 0; i < 11; i++) {
        for (int j = 0; j < 11; j++) {
            tablero[0][j] = "Y" + j;
            tablero[i][0] = "X" + i;
            
            if (i == coordenadaXA && j == coordenadaYA) {
                tablero[coordenadaXA][coordenadaYA] = "x";
            } else if (tablero[i][j].equals("x")) {
              
            } else if (posicion == 0 && longitud == 3) {
                if (i == coordenadaX && j >= coordenadaY && j < coordenadaY + 3) {
                    tablero[i][j] = "0";
                }
            } else if (posicion == 1 && longitud == 3) {
                if (j == coordenadaY && i >= coordenadaX && i < coordenadaX + 3) {
                    tablero[i][j] = "0";
                }
            } else if (posicion == 0 && longitud == 4) {
                if (i == coordenadaX && j >= coordenadaY && j < coordenadaY + 4) {
                    tablero[i][j] = "0";
                }
            } else if (posicion == 1 && longitud == 4) {
                if (j == coordenadaY && i >= coordenadaX && i < coordenadaX + 4) {
                    tablero[i][j] = "0";
                }
            } else {
                tablero[i][j] = "~";
            }
        }
    }
    
    for (int i = 0; i < 11; i++) {
        for (int j = 0; j < 11; j++) {
            System.out.printf("%-7s", tablero[i][j]);
        }
        System.out.println("");
    }
}

        
        
        
    public static void seleccionPosicion() {
        posicion=sc.nextInt();
        while (posicion<0 || posicion>1) {
            System.out.println("Seleccione la opción correcta");
            posicion=sc.nextInt();
        }
      }
    
    public static void seleccionLongitud() {
        longitud=sc.nextInt();
        while (longitud<3 || longitud>=5) {
            System.out.println("Seleccione la opción correcta");
            longitud=sc.nextInt();
        }
    }
    
    public static void seleccionCoordenadaInicial() {
        
        System.out.println("Coordenada x");
        coordenadaX=sc.nextInt();
        System.out.println("Coordenada y");
        coordenadaY=sc.nextInt();
        while (coordenadaX<1 || coordenadaX>10 || coordenadaY<1 || coordenadaY>10) {
        System.out.println("Seleccionó una opción incorrecta o para x o para y \ningrese la coordenada de la forma (x,y) " );
        System.out.println("\nCoordenada x");
        coordenadaX=sc.nextInt();
        System.out.println("Coordenada y");
        coordenadaY=sc.nextInt();
        
        
}

    }
    
    public static void seleccionCoordenadaAtaque() {
               
        System.out.println("Coordenada x");
        coordenadaXA=sc.nextInt();
        System.out.println("Coordenada y");
        coordenadaYA=sc.nextInt();
        while (coordenadaXA<1 || coordenadaXA>10 || coordenadaYA<1 || coordenadaYA>10) {
        System.out.println("Seleccionó una opción incorrecta o para x o para y \ningrese la coordenada de la forma (x,y) " );
        System.out.println("\nCoordenada x");
        coordenadaXA=sc.nextInt();
        System.out.println("Coordenada y");
        coordenadaYA=sc.nextInt();

}
        
         if (tablero[coordenadaXA][coordenadaYA].equals("0")) {
        System.out.println("¡Acierto! Ha atacado un barco.\n");
       // tablero[coordenadaXA][coordenadaYA] = "x"; 
    } else {
        System.out.println("¡Desacierto! No ha atacado un barco.\n");
       // tablero[coordenadaXA][coordenadaYA] = "X"; 
    }

    tableroActualizacion();
    }
    

}
