public class StringUtils {

    public static void stat(String s){
        int[] output={0,0,0};
        String maganhangzo="aeiouAEIOU";
        String massalhangzo="bcdfghjklmnprstvwxyzBCDFGHJKLMNPRSTVWXYZ";
        String szamok="0123456789";



        for (int i = 0; i <s.length() ; i++) {
            if (maganhangzo.contains(Character.toString(s.charAt(i)))) output[0]++;
            if (massalhangzo.contains(Character.toString(s.charAt(i)))) output[1]++;
            if (szamok.contains(Character.toString(s.charAt(i)))) output[2]++;
        }
        System.out.println("Magánhangzók száma:"+output[0]);
        System.out.println("Mássalhangzók száma:"+output[1]);
        System.out.println("Számjegyek száma:"+output[2]);
    }
}
