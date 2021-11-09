import java.util.ArrayList;
import java.util.Collection;
import java.util.Collections;
import java.util.List;

public class Playlist {
    List<Song> playlist= new ArrayList<>();



    public void add(Song s){
        playlist.add(s);
    }

    public void shufflePlaylist(){
        Collections.shuffle(playlist);
    }

    public int calculateTotalLength(){
        int ido=0;
        for(Song e: playlist){
            ido+= e.getHossz();
        }
        return ido;
    }

    public void printPlaylist(){
        System.out.println("Lejatszasi lista: ");
        for (Song e : playlist){
            System.out.println("-"+e.getTitle()+'('+e.getArtist()+')');
        }
    }
}
