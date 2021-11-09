import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        List<String> input= new ArrayList<>(FileUtils.readLines("ips.txt"));
        boolean ok=true;
        char ch='.';
        int validipszam=0;
        for (String e: input){

            if (MyUtils.isValidIP(e)) validipszam++;

        }




        System.out.println(validipszam);
    }
}
