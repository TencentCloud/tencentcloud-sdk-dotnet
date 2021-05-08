/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputManageMarketingRisk : AbstractModel
    {
        
        /// <summary>
        /// 账号信息。
        /// </summary>
        [JsonProperty("Account")]
        public AccountInfo Account{ get; set; }

        /// <summary>
        /// 场景类型：场景SceneCode, 控制台上新建对应的场景并获取对应的值；
        /// 例如：e_register_protection_1521184361
        /// 控制台链接：https://console.cloud.tencent.com/rce/risk/sceneroot；
        /// </summary>
        [JsonProperty("SceneCode")]
        public string SceneCode{ get; set; }

        /// <summary>
        /// 登录来源的外网IP
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 用户操作时间戳，单位秒（格林威治时间精确到秒，如1501590972）。
        /// </summary>
        [JsonProperty("PostTime")]
        public ulong? PostTime{ get; set; }

        /// <summary>
        /// 用户唯一标识。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 设备指纹token。
        /// </summary>
        [JsonProperty("DeviceToken")]
        public string DeviceToken{ get; set; }

        /// <summary>
        /// 设备指纹BusinessId
        /// </summary>
        [JsonProperty("DeviceBusinessId")]
        public long? DeviceBusinessId{ get; set; }

        /// <summary>
        /// 业务ID。网站或应用在多个业务中使用此服务，通过此ID区分统计数据。
        /// </summary>
        [JsonProperty("BusinessId")]
        public ulong? BusinessId{ get; set; }

        /// <summary>
        /// 昵称，UTF-8 编码。
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 用户邮箱地址（非系统自动生成）。
        /// </summary>
        [JsonProperty("EmailAddress")]
        public string EmailAddress{ get; set; }

        /// <summary>
        /// 是否识别设备异常：
        /// 0：不识别。
        /// 1：识别。
        /// </summary>
        [JsonProperty("CheckDevice")]
        public long? CheckDevice{ get; set; }

        /// <summary>
        /// 用户HTTP请求中的Cookie进行2次hash的值，只要保证相同Cookie的hash值一致即可。
        /// </summary>
        [JsonProperty("CookieHash")]
        public string CookieHash{ get; set; }

        /// <summary>
        /// 用户HTTP请求的Referer值。
        /// </summary>
        [JsonProperty("Referer")]
        public string Referer{ get; set; }

        /// <summary>
        /// 用户HTTP请求的User-Agent值。
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// 用户HTTP请求的X-Forwarded-For值。
        /// </summary>
        [JsonProperty("XForwardedFor")]
        public string XForwardedFor{ get; set; }

        /// <summary>
        /// MAC地址或设备唯一标识。
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// 手机制造商ID，如果手机注册，请带上此信息。
        /// </summary>
        [JsonProperty("VendorId")]
        public string VendorId{ get; set; }

        /// <summary>
        /// 设备类型：
        /// 1：Android
        /// 2：IOS
        /// </summary>
        [JsonProperty("DeviceType")]
        public long? DeviceType{ get; set; }

        /// <summary>
        /// 详细信息
        /// FieldName 清单
        /// Android serial_number String 否 设备序列号
        /// Android carrier String 否 运营商；-1: 获取失败，0: 其他，1: 移动，2: 联通，3: 电信，4: 铁通
        /// Android mcc_mnc String 否 netOperator MCC+MNC
        /// Android model String 否 手机型号
        /// Android os_system String 否 操作系统
        /// Android vendor_id String 否 设备品牌 “华为”“oppo”“小米”
        /// Android device_version String 否 设备版本
        /// Android android_api_level String 否 安卓API等级
        /// Android phone_chip_info String 否 手机芯片信息
        /// Android resolution_w String 否 屏幕分辨率宽，保留整数
        /// Android resolution_h String 否 屏幕分辨率高，保留整数
        /// Android brightness String 否 屏幕亮度
        /// Android bluetooth_address String 否 蓝牙地址
        /// Android baseband_version String 否 基带版本
        /// Android kernel_version String 否 kernel 版本
        /// Android cpu_core String 否 CPU 核数
        /// Android cpu_model String 否 CPU 型号
        /// Android memory String 否 内存容量，单位转换为 GB
        /// Android storage String 否 存储容量，单位转换为 GB
        /// Android volume String 否 手机音量
        /// Android battery_power String 否 电池电量
        /// Android language String 否 语言
        /// Android package_name String 否 软件包名
        /// Android App_version String 否 App 版本号
        /// Android App_name String 否 App 显示名称
        /// Android is_debug String 否 是否 debug；0 为正常模式，1 为 debug 模式；其他值无效
        /// Android is_root String 否 是否越狱；0 为正常，1 为越狱；其他值无效
        /// Android is_proxy String 否 是否启动代理；0 为未开启，1 为开启；其他值无效
        /// Android is_emulator String 否 是否模拟器；0 为未开启，1 为开启；其他值无效
        /// Android charge_status String 否 充电状态；1-不在充电，2-USB充电，3-电源充电
        /// Android network_type String 否 网络类型：2G/3G/4G/5G/WiFi/WWAN/other
        /// Android wifi_mac String 否 WiFi MAC地址
        /// IOS model String 否 机器型号 iPhone11
        /// IOS memory String 否 内存容量，单位转换为 GB
        /// IOS os_system String 否 操作系统
        /// IOS device_version String 否 设备版本
        /// IOS phone_chip_info String 否 手机芯片信息
        /// IOS device_name String 否 设备名称 "xxx 的 iPhone"，"xxx's IPhone" 等等
        /// IOS uptime String 否 开机时间
        /// IOS language String 否 系统语言
        /// IOS carrier String 否 运营商
        /// IOS cpu_model String 否 CPU 型号
        /// IOS cpu_core String 否 CPU 个数
        /// IOS volume String 否 手机音量
        /// IOS battery_power String 否 电池电量
        /// IOS resolution_w String 否 屏幕分辨率宽，保留整数
        /// IOS resolution_h String 否 屏幕分辨率高，保留整数
        /// IOS package_name String 否 App 包名
        /// IOS App_version String 否 App 版本号
        /// IOS App_name String 否 App 显示名称
        /// IOS is_debug String 否 是否 debug；0 为正常模式，1 为 debug 模式；其他值无效
        /// IOS is_root String 否 是否越狱；0 为正常，1 为越狱；其他值无效
        /// IOS is_proxy String 否 是否启动代理；0 为未开启，1 为开启；其他值无效
        /// IOS is_emulator String 否 是否模拟器；0 为未开启，1 为开启；其他值无效
        /// IOS charge_status String 否 充电状态；1-不在充电，2-USB充电，3-电源充电
        /// IOS network_type String 否 网络类型：2G/3G/4G/5G/WiFi/WWAN/other
        /// IOS wifi_mac String 否 WiFi MAC地址
        /// 其他 os_system String 否 操作系统
        /// 其他 browser String 否 浏览器信息
        /// 其他 from_url String 否 来源链接
        /// </summary>
        [JsonProperty("Details")]
        public InputDetails[] Details{ get; set; }

        /// <summary>
        /// 可选填写。详情请跳转至SponsorInfo查看。
        /// </summary>
        [JsonProperty("Sponsor")]
        public SponsorInfo Sponsor{ get; set; }

        /// <summary>
        /// 可选填写。详情请跳转至OnlineScamInfo查看。
        /// </summary>
        [JsonProperty("OnlineScam")]
        public OnlineScamInfo OnlineScam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Account.", this.Account);
            this.SetParamSimple(map, prefix + "SceneCode", this.SceneCode);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "PostTime", this.PostTime);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "DeviceToken", this.DeviceToken);
            this.SetParamSimple(map, prefix + "DeviceBusinessId", this.DeviceBusinessId);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "EmailAddress", this.EmailAddress);
            this.SetParamSimple(map, prefix + "CheckDevice", this.CheckDevice);
            this.SetParamSimple(map, prefix + "CookieHash", this.CookieHash);
            this.SetParamSimple(map, prefix + "Referer", this.Referer);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "XForwardedFor", this.XForwardedFor);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "VendorId", this.VendorId);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamArrayObj(map, prefix + "Details.", this.Details);
            this.SetParamObj(map, prefix + "Sponsor.", this.Sponsor);
            this.SetParamObj(map, prefix + "OnlineScam.", this.OnlineScam);
        }
    }
}

