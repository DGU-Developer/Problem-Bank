/*
 * �������� 13-10 (1). 8-Queens Problem
     ---  to place eight queens on an 8*8 chessboard so that
          no two attack,  that is so that no two of them are
          on the same row, column or diagonal.
 */

public class EightQueens {
    int     Size;
    int[]   ColPos;
    boolean Possible;
    boolean[] R, Rd, Ld;
    
    EightQueens(int size) {
        Size = size;
        
        ColPos = new int[Size];
        R = new boolean[Size];
        Rd = new boolean[Size * Size];
        Ld = new boolean[Size * Size];
    }
    
    void locateQueens(int i) {
       int j = 0;
    
       Possible = false;
       while ((!Possible) && (j < Size)) {
         if (isSafe(i,j)) {
             putQueen(i,j);
             if (i < Size-1) {
                 locateQueens(i+1);
                 if (!Possible) removeQueen(i,j);
             }
             else Possible = true;
         } 
         j++;
      }
    }

    void printPosition() {
        int i, j;
        
        System.out.print("\n    !! Queens coordinate is shown below !! \n");
        System.out.print("\t  ");
        for (i=1; i<=Size; i++) 
        {
            System.out.print("  ");
            System.out.print(i);
        }
        System.out.print('\n');
        
        for(i=0; i < Size; i++) {
            System.out.print("\t");
            System.out.print(i + 1);
            for (j=0; j < (ColPos[i] + 1) * 3; j++) 
                System.out.print(' ');
            System.out.print('Q'); 
            System.out.print('\n');
        }
    }
    
    void putQueen(int row, int col) {
        ColPos[row] = col;
        R[col] = false;
        Ld[row + col] = false;  
        Rd[row - col + Size] = false;
    }
    
    void removeQueen(int row, int col) {
        R[col] = true;
        Ld[row + col] = true;
        Rd[row - col + Size] = true;
    }
    
    boolean isSafe(int row, int col) {
        return ( R[col] && Ld[row + col] && Rd[row - col + Size] );
    }
    
    void run() {
        int i;
        
        for (i=0; i < Size; ++i)  
            R[i] = true;
            
        for (i=0; i < Size * Size; ++i) 
            Rd[i] = Ld[i] = true;
            
        locateQueens(0);
        if (Possible) 
            printPosition();
        else 
            System.out.print("\n  ImPossible !!!\n");
    }
    
    public static void main(String[] args) {
        new EightQueens(8).run(); /*  Eight-Queens Problem */
    }
}