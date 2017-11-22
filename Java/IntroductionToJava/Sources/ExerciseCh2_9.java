import java.io.*;

public class ExerciseCh2_9 {
	public static void main( String[] args ) throws java.io.IOException {
		int buf;
		
		buf = System.in.read();
		
		while( buf != -1 ) {
			if( buf == '/' ) {
				buf = System.in.read();
				if( buf == '*' ) {
					do {
						buf = System.in.read();
					} while( buf != '*' );
					
					buf = System.in.read();
						
					if( buf == '/' ) {
						buf = System.in.read();
						continue;
					}
				}
				else if( buf == '/' ){
					do {
						buf = System.in.read();
					} while( buf != '\n' );
				}
				continue;			
			}
			else {
				System.out.write( buf );
				buf = System.in.read();
			}
		}
	}
}