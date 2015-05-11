package de.swk;

import com.google.common.base.Joiner;

import java.util.ArrayList;
import java.util.List;

public class HappyNumber {

    public static boolean isHappy(int number) {
        int result = calculateHappySum(number);

        if (result == 1)
            return true;

        else if (result == 0 || result == 4)
            return false;

        return isHappy(result);
    }

    private static int calculateHappySum(int number) {
        char[] digits = Integer.toString(number).toCharArray();

        int result = 0;
        for (char digit : digits) {
            result += Math.pow(Character.getNumericValue(digit), 2);
        }

        return result;
    }

    public static void main(String[] args) {
        List<Integer> happyNumbers = new ArrayList<Integer>();
        for (int i = 0; i < 200; i++) {
            if (isHappy(i)) {
                happyNumbers.add(i);
            }
        }
        System.out.println(Joiner.on(";").join(happyNumbers));
    }

}
