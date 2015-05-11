package de.swk;

import org.junit.Test;

import static org.junit.Assert.assertFalse;
import static org.junit.Assert.assertTrue;

public class HappyNumberTest {

    @Test
    public void testZeroIsNotHappy() {
        assertFalse(HappyNumber.isHappy(0));
    }

    @Test
    public void testOneIsHappy() {
        assertTrue(HappyNumber.isHappy(1));
    }

    @Test
    public void testFourIsNotHappy() {
        assertFalse(HappyNumber.isHappy(4));
    }

    @Test
    public void testSevenIsHappy() {
        assertTrue(HappyNumber.isHappy(7));
    }

    @Test
    public void testNineteenIsHappy() {
        assertTrue(HappyNumber.isHappy(19));
    }

    @Test
    public void testTwentyIsNotHappy() {
        assertFalse(HappyNumber.isHappy(20));
    }

}