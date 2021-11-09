import java.util.ArrayList;
import java.util.List;

public class MyUtils {
    public static boolean isValidIP(String s){

        List<Integer> seged = new ArrayList<>();

        String str="";

        for (int i=0;i<s.length();i++){
            if (s.charAt(i)=='.'){
                seged.add(Integer.parseInt(str));
                str="";
            }
            if (s.charAt(i)!='.')
                str+= s.charAt(i);

        }

        for (Integer e: seged){
            if (e>255 || e<0) return false;
        }

        return true;
    }
}
