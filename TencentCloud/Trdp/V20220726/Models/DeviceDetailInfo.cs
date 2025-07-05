/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Trdp.V20220726.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeviceDetailInfo : AbstractModel
    {
        
        /// <summary>
        /// mac地址或唯一设备标识
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// 手机型号
        /// </summary>
        [JsonProperty("Model")]
        public string Model{ get; set; }

        /// <summary>
        /// 操作系统(unknown，android，ios，windows)
        /// </summary>
        [JsonProperty("OsSystem")]
        public string OsSystem{ get; set; }

        /// <summary>
        /// 操作系统版本
        /// </summary>
        [JsonProperty("OsSystemVersion")]
        public string OsSystemVersion{ get; set; }

        /// <summary>
        /// 竞价底价
        /// </summary>
        [JsonProperty("BidFloor")]
        public long? BidFloor{ get; set; }

        /// <summary>
        /// 设备版本
        /// </summary>
        [JsonProperty("DeviceVersion")]
        public string DeviceVersion{ get; set; }

        /// <summary>
        /// 设备制造商
        /// </summary>
        [JsonProperty("Maker")]
        public string Maker{ get; set; }

        /// <summary>
        /// 设备类型（PHONE,TABLET）
        /// </summary>
        [JsonProperty("DeviceType")]
        public string DeviceType{ get; set; }

        /// <summary>
        /// 运营商；-1: 获取失败，0: 其他，1: 移动，2: 联通，3: 电信，4: 铁通
        /// </summary>
        [JsonProperty("Carrier")]
        public string Carrier{ get; set; }

        /// <summary>
        /// 入网方式(wifi,5g,4g,3g,2g)
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// 手机芯片信息
        /// </summary>
        [JsonProperty("PhoneChipInfo")]
        public string PhoneChipInfo{ get; set; }

        /// <summary>
        /// CPU 型号
        /// </summary>
        [JsonProperty("CpuModel")]
        public string CpuModel{ get; set; }

        /// <summary>
        /// CPU 核数
        /// </summary>
        [JsonProperty("CpuCore")]
        public string CpuCore{ get; set; }

        /// <summary>
        /// 内存容量，单位转换为 GB
        /// </summary>
        [JsonProperty("Memory")]
        public string Memory{ get; set; }

        /// <summary>
        /// 系统语言
        /// </summary>
        [JsonProperty("Language")]
        public string Language{ get; set; }

        /// <summary>
        /// 手机音量
        /// </summary>
        [JsonProperty("Volume")]
        public string Volume{ get; set; }

        /// <summary>
        /// 电池电量
        /// </summary>
        [JsonProperty("BatteryPower")]
        public string BatteryPower{ get; set; }

        /// <summary>
        /// 屏幕分辨率宽，保留整数
        /// </summary>
        [JsonProperty("ResolutionWidth")]
        public long? ResolutionWidth{ get; set; }

        /// <summary>
        /// 屏幕分辨率高，保留整数
        /// </summary>
        [JsonProperty("ResolutionHeight")]
        public long? ResolutionHeight{ get; set; }

        /// <summary>
        /// 浏览器类型
        /// </summary>
        [JsonProperty("Ua")]
        public string Ua{ get; set; }

        /// <summary>
        /// 客户端应用
        /// </summary>
        [JsonProperty("App")]
        public string App{ get; set; }

        /// <summary>
        /// 应用包名
        /// </summary>
        [JsonProperty("AppPackageName")]
        public string AppPackageName{ get; set; }

        /// <summary>
        /// 设备序列号
        /// Android设备
        /// </summary>
        [JsonProperty("SerialNumber")]
        public string SerialNumber{ get; set; }

        /// <summary>
        /// netOperator MCC+MNC
        /// Android设备
        /// </summary>
        [JsonProperty("MobileCountryAndNetworkCode")]
        public string MobileCountryAndNetworkCode{ get; set; }

        /// <summary>
        /// 设备品牌 “华为”“oppo”“小米”
        /// Android设备
        /// </summary>
        [JsonProperty("VendorId")]
        public string VendorId{ get; set; }

        /// <summary>
        /// Android API等级
        /// Android设备
        /// </summary>
        [JsonProperty("AndroidApiLevel")]
        public string AndroidApiLevel{ get; set; }

        /// <summary>
        /// 屏幕亮度
        /// Android设备
        /// </summary>
        [JsonProperty("Brightness")]
        public string Brightness{ get; set; }

        /// <summary>
        /// 蓝牙地址
        /// Android设备
        /// </summary>
        [JsonProperty("BluetoothAddress")]
        public string BluetoothAddress{ get; set; }

        /// <summary>
        /// 基带版本
        /// Android设备
        /// </summary>
        [JsonProperty("BaseBandVersion")]
        public string BaseBandVersion{ get; set; }

        /// <summary>
        /// kernel 版本
        /// Android设备
        /// </summary>
        [JsonProperty("KernelVersion")]
        public string KernelVersion{ get; set; }

        /// <summary>
        /// 存储容量，单位转换为 GB
        /// Android设备
        /// </summary>
        [JsonProperty("Storage")]
        public string Storage{ get; set; }

        /// <summary>
        /// 软件包名
        /// Android设备
        /// </summary>
        [JsonProperty("PackageName")]
        public string PackageName{ get; set; }

        /// <summary>
        /// app 版本号
        /// Android设备
        /// </summary>
        [JsonProperty("AppVersion")]
        public string AppVersion{ get; set; }

        /// <summary>
        /// app 显示名称
        /// Android设备
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// 是否 debug；0 为正常模式，1 为 debug 模式；其他值无效
        /// Android设备
        /// </summary>
        [JsonProperty("IsDebug")]
        public string IsDebug{ get; set; }

        /// <summary>
        /// 是否越狱；0 为正常，1 为越狱；其他值无效
        /// Android设备
        /// </summary>
        [JsonProperty("IsRoot")]
        public string IsRoot{ get; set; }

        /// <summary>
        /// 是否启动代理；0 为未开启，1 为开启；其他值无效
        /// Android设备
        /// </summary>
        [JsonProperty("IsProxy")]
        public string IsProxy{ get; set; }

        /// <summary>
        /// 是否模拟器；0 为未开启，1 为开启；其他值无效
        /// Android设备
        /// </summary>
        [JsonProperty("IsEmulator")]
        public string IsEmulator{ get; set; }

        /// <summary>
        /// 充电状态；1-不在充电，2-USB充电，3-电源充电
        /// Android设备
        /// </summary>
        [JsonProperty("ChargeStatus")]
        public string ChargeStatus{ get; set; }

        /// <summary>
        /// 网络类型：2G/3G/4G/5G/Wi-Fi/WWAN/other
        /// Android设备
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// Wi-Fi MAC地址
        /// Android设备
        /// </summary>
        [JsonProperty("WifiMac")]
        public string WifiMac{ get; set; }

        /// <summary>
        /// 设备名称 "xxx 的 iPhone"，"xxx's IPhone" 等等
        /// IOS设备
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 开机时间
        /// IOS设备
        /// </summary>
        [JsonProperty("StartupTime")]
        public string StartupTime{ get; set; }

        /// <summary>
        /// 所在经度
        /// </summary>
        [JsonProperty("Lon")]
        public string Lon{ get; set; }

        /// <summary>
        /// 所在纬度
        /// </summary>
        [JsonProperty("Lat")]
        public string Lat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "Model", this.Model);
            this.SetParamSimple(map, prefix + "OsSystem", this.OsSystem);
            this.SetParamSimple(map, prefix + "OsSystemVersion", this.OsSystemVersion);
            this.SetParamSimple(map, prefix + "BidFloor", this.BidFloor);
            this.SetParamSimple(map, prefix + "DeviceVersion", this.DeviceVersion);
            this.SetParamSimple(map, prefix + "Maker", this.Maker);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "Carrier", this.Carrier);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "PhoneChipInfo", this.PhoneChipInfo);
            this.SetParamSimple(map, prefix + "CpuModel", this.CpuModel);
            this.SetParamSimple(map, prefix + "CpuCore", this.CpuCore);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Language", this.Language);
            this.SetParamSimple(map, prefix + "Volume", this.Volume);
            this.SetParamSimple(map, prefix + "BatteryPower", this.BatteryPower);
            this.SetParamSimple(map, prefix + "ResolutionWidth", this.ResolutionWidth);
            this.SetParamSimple(map, prefix + "ResolutionHeight", this.ResolutionHeight);
            this.SetParamSimple(map, prefix + "Ua", this.Ua);
            this.SetParamSimple(map, prefix + "App", this.App);
            this.SetParamSimple(map, prefix + "AppPackageName", this.AppPackageName);
            this.SetParamSimple(map, prefix + "SerialNumber", this.SerialNumber);
            this.SetParamSimple(map, prefix + "MobileCountryAndNetworkCode", this.MobileCountryAndNetworkCode);
            this.SetParamSimple(map, prefix + "VendorId", this.VendorId);
            this.SetParamSimple(map, prefix + "AndroidApiLevel", this.AndroidApiLevel);
            this.SetParamSimple(map, prefix + "Brightness", this.Brightness);
            this.SetParamSimple(map, prefix + "BluetoothAddress", this.BluetoothAddress);
            this.SetParamSimple(map, prefix + "BaseBandVersion", this.BaseBandVersion);
            this.SetParamSimple(map, prefix + "KernelVersion", this.KernelVersion);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "PackageName", this.PackageName);
            this.SetParamSimple(map, prefix + "AppVersion", this.AppVersion);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "IsDebug", this.IsDebug);
            this.SetParamSimple(map, prefix + "IsRoot", this.IsRoot);
            this.SetParamSimple(map, prefix + "IsProxy", this.IsProxy);
            this.SetParamSimple(map, prefix + "IsEmulator", this.IsEmulator);
            this.SetParamSimple(map, prefix + "ChargeStatus", this.ChargeStatus);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "WifiMac", this.WifiMac);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "StartupTime", this.StartupTime);
            this.SetParamSimple(map, prefix + "Lon", this.Lon);
            this.SetParamSimple(map, prefix + "Lat", this.Lat);
        }
    }
}

