using UnityEngine;

namespace CricketCardBoliBattle
{
    // Prototype only. Never use local PlayerPrefs for competitive online rewards.
    public static class CoinWallet
    {
        private const string Key = "CCBB_VirtualCoins";
        public static int Balance => PlayerPrefs.GetInt(Key, GameConfig.StartingCoins);

        public static bool TrySpend(int amount)
        {
            if (amount < 0 || Balance < amount) return false;
            PlayerPrefs.SetInt(Key, Balance - amount);
            PlayerPrefs.Save();
            return true;
        }

        public static void Add(int amount)
        {
            if (amount <= 0) return;
            PlayerPrefs.SetInt(Key, Balance + amount);
            PlayerPrefs.Save();
        }
    }
}
