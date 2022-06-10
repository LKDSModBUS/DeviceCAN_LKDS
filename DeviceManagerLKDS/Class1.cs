using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace DeviceManagerLKDS
{
    public static class ClassDeviceInfo 
    {
        public static string GetNameOfEnum(this Enum enumVal)
        {
            var type = enumVal.GetType();
            var memInfo = type.GetMember(enumVal.ToString());
            try
            {
                var attributes = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                return (attributes.Length > 0) ? ((DescriptionAttribute)attributes[0]).Description : "";
            }
            catch
            {
                return Convert.ToInt16(enumVal).ToString("X4");
            }

        }

        public enum CAN_Devices
        {
            [Description("ЛБ/Концентратор")]
            LB = 0, 
            [Description("USB - VOICE converter")]
            USB = 2, 
            [Description("VRP - VIDEO converter")]
            VRP = 3, 
            [Description("Переговорное устройство v7(ПУv7)")]
            PU = 4, 
            [Description("Переговорное устройство этажное v7(ЭПУv7)")]
            EPU = 5,
            [Description("Удлинитель WiFi v7")]
            wifi = 6,
            [Description("Адаптер входов v7(АСК-16)")]
            ASK = 7,
            [Description("Адаптер ТУ v7(АТУ-8*2)")]
            ATU = 8,
            [Description("Адаптер ПУ v7(АПУ-1)")]
            APU = 9,
            [Description("Адаптер Последовательного Интерфейса(АПИ-1)")]
            API = 10,
            [Description("Портал Контроллер Доступа (ПКД2*2)")]
            PKD22 = 11,
            [Description("Портал Контроллер Доступа (ПКД2*16)")]
            PKD216 = 12,
            [Description("Переговорное устр. Аккум. платформы (ПУ АП)")]
            PUAP = 13,
            [Description("Адаптер релейных выходов (АРВ-8*6)")]
            ARV = 14,
            [Description("Адаптер Лампа Индикаторная (АЛИ-1)")]
            ALI = 15,
            [Description("Адаптер Токовых Сигналов (АТС-4*4)")]
            ATS = 16,
            [Description("Адаптер ModBUS (АМБ-1)")]
            AMB = 17,
            [Description("Адаптер Звукового Оповещения (АЗО-1)")]
            AZO = 18,
            [Description("Адаптер Переговорного Устройства 2 (АПУ-2)")]
            APU2 = 19,
            [Description("Переговорное устройство посадоч. площ.(ПУ ПП)")]
            PUPP = 20,
            [Description("Выносной Модуль Управления (ВМУ)")]
            VMU = 21,
            [Description("Адаптер шлейфов (АШЛ-6*4)")]
            ASHL = 22,
            [Description("Портал Контроллер Доступа (ПКД1*2)")]
            PKD12 = 24,
            [Description("ПКД2*2-режим Команд")]
            PKD22CR = 25,
            [Description("ПКД2*16-режим Команд")]
            PKD216CR = 26,
            [Description("ПКД2*1-режим Команд")]
            PKD21CR = 27,
            [Description("Тип не определен")]
            notype = 255,
        }
        public enum Device_Status
        {
            [Description("Инициализация-нет данных")]
            ninitialization = 0,
            [Description("Ожидание готовности устройства-нет жанных")]
            nwaiting_readiness = 1,
            [Description("Ожидание данных устройства-нет данных")]
            waiting_data = 2,
            [Description("Данные устарели-не обновлялись более 30 сек")]
            data_outdated = 3,
            [Description("Данные актуальны-подлежат интерпретации")]
            data_actual = 4,
            [Description("Обнаружен рестарт устройства-нет данных")]
            restart = 5,
        }
        public enum Key_Format
        {
            [Description("Неизвестный формат ключа")]
            unknown_format = 0x00,
            [Description("Формат ключа Dallas")]
            dallas = 0x01,
            [Description("EM-Marine")]
            em_marine = 0x02,
            [Description("EM-Marine (ручной ввод)")]
            em_marine_manual_input = 0x03,
            [Description("Mifare Classic")]
            mifare_classic = 0x04,
            [Description("Mifare Classic (ручной ввод)")]
            mifare_classic_manual_input = 0x05,
            [Description("Mifare 1K")]
            mifare_1K = 0x06,
            [Description("Mifare 1K (ручной ввод)")]
            mifare_1K_manual_input = 0x07,
            [Description("Mifare 4K")]
            mifare_4K = 0x08,
            [Description("Mifare 4K (ручной ввод)")]
            mifare_4K_manual_input = 0x09,
            [Description("Mifare UltraLight")]
            mifare_ultra_light = 0x0A,
            [Description("Mifare UltraLight (ручной ввод)")]
            mifare_ultra_light_manual_input = 0x0B,
            [Description("HID ProxCard II")]
            HID_Prox_Card_II = 0x0C,
            [Description("HID ProxCard II (ручной ввод)")]
            HID_Prox_Card_II_manual_input = 0x0D,
            [Description("клавиатура")]
            keyboard = 0x0E,
            [Description("RF-433тип 1")]
            rf = 0x0F,
            [Description("Wiegand - абстрактный ключ, полученный в формате Wiegand")]
            wiegand = 0x10,
            [Description("кнопка (открывания)")]
            opening_button = 0x11,
        }
    }
}
