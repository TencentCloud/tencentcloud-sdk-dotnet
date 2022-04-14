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

namespace TencentCloud.Af.V20200226.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AntiFraudFilter : AbstractModel
    {
        
        /// <summary>
        /// 业务方账号 ID
        /// </summary>
        [JsonProperty("CustomerUin")]
        public string CustomerUin{ get; set; }

        /// <summary>
        /// 业务方APPID
        /// </summary>
        [JsonProperty("CustomerAppid")]
        public string CustomerAppid{ get; set; }

        /// <summary>
        /// 身份证号
        /// 注 1：下方 idCryptoType 为指定
        /// 加密方式
        /// 注 2：若 idNumber 加密则必传加
        /// 密方式
        /// </summary>
        [JsonProperty("IdNumber")]
        public string IdNumber{ get; set; }

        /// <summary>
        /// 手机号码（注：不需要带国家代码
        /// 例如：13430421011）
        /// 注 1：下方 phoneCryptoType 为
        /// 指定加密方式:
        /// 注 2：若 phoneNumber 加密则必
        /// 传加密方式
        /// </summary>
        [JsonProperty("PhoneNumber")]
        public string PhoneNumber{ get; set; }

        /// <summary>
        /// 业务场景 ID
        /// </summary>
        [JsonProperty("Scene")]
        public string Scene{ get; set; }

        /// <summary>
        /// 默认不使用，业务方子
        /// 账号，若接口使用密钥对应是子账
        /// 号则必填
        /// </summary>
        [JsonProperty("CustomerSubUin")]
        public string CustomerSubUin{ get; set; }

        /// <summary>
        /// 已获取约定标识则传 1；
        /// 用于基于特定需求而传的标识字段
        /// 注：有约定则是必传，若未传则查
        /// 询接口失败
        /// </summary>
        [JsonProperty("Authorization")]
        public string Authorization{ get; set; }

        /// <summary>
        /// 姓名
        /// 注 ：不支持加密
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 银行卡号
        /// </summary>
        [JsonProperty("BankCardNumber")]
        public string BankCardNumber{ get; set; }

        /// <summary>
        /// 用户请求来源 IP
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 国际移动设备识别码
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// ios 系统广告标示符
        /// </summary>
        [JsonProperty("Idfa")]
        public string Idfa{ get; set; }

        /// <summary>
        /// 用户邮箱地址
        /// </summary>
        [JsonProperty("EmailAddress")]
        public string EmailAddress{ get; set; }

        /// <summary>
        /// 用户住址
        /// </summary>
        [JsonProperty("Address")]
        public string Address{ get; set; }

        /// <summary>
        /// MAC 地址
        /// </summary>
        [JsonProperty("Mac")]
        public string Mac{ get; set; }

        /// <summary>
        /// 国际移动用户识别码
        /// </summary>
        [JsonProperty("Imsi")]
        public string Imsi{ get; set; }

        /// <summary>
        /// 关联的腾讯帐号 QQ：1；
        /// 开放帐号微信： 2；
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// 可选的 QQ 或微信 openid
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// qq 或微信分配给网站或应用的
        /// appid，用来唯一标识网站或应用
        /// </summary>
        [JsonProperty("AppIdU")]
        public string AppIdU{ get; set; }

        /// <summary>
        /// ＷＩＦＩＭＡＣ
        /// </summary>
        [JsonProperty("WifiMac")]
        public string WifiMac{ get; set; }

        /// <summary>
        /// WIFI 服务集标识
        /// </summary>
        [JsonProperty("WifiSSID")]
        public string WifiSSID{ get; set; }

        /// <summary>
        /// WIFI-BSSID
        /// </summary>
        [JsonProperty("WifiBSSID")]
        public string WifiBSSID{ get; set; }

        /// <summary>
        /// 拓展字段类型 ID
        /// 注：默认不填写，需要时天御侧将
        /// 提供
        /// </summary>
        [JsonProperty("ExtensionId")]
        public string ExtensionId{ get; set; }

        /// <summary>
        /// 拓展字段内容
        /// 注：默认不填，需要时天御侧将提
        /// 供
        /// </summary>
        [JsonProperty("ExtensionIn")]
        public string ExtensionIn{ get; set; }

        /// <summary>
        /// 业务 ID，默认不传
        /// </summary>
        [JsonProperty("BusinessId")]
        public string BusinessId{ get; set; }

        /// <summary>
        /// 身份证加密类型
        /// 0：不加密（默认值）
        /// 1：md5
        /// 2：sha256
        /// 3：SM3
        /// 注：若 idNumber 加密则必传加密
        /// 方式
        /// </summary>
        [JsonProperty("IdCryptoType")]
        public string IdCryptoType{ get; set; }

        /// <summary>
        /// 手机号加密类型
        /// 0：不加密（默认值）
        /// 1：md5,
        /// 2：sha256
        /// 3：SM3
        /// 注：若 phoneNumber 加密则必传
        /// 加密方式
        /// </summary>
        [JsonProperty("PhoneCryptoType")]
        public string PhoneCryptoType{ get; set; }

        /// <summary>
        /// 姓名加密类型：——注：已经不支持加
        /// 密，该字段存在是为了兼容可能历史客户
        /// 版本；
        /// 0：不加密（默认值）
        /// 1：md5
        /// </summary>
        [JsonProperty("NameCryptoType")]
        public string NameCryptoType{ get; set; }

        /// <summary>
        /// 是否使用旧回包
        /// </summary>
        [JsonProperty("OldResponseType")]
        public string OldResponseType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerUin", this.CustomerUin);
            this.SetParamSimple(map, prefix + "CustomerAppid", this.CustomerAppid);
            this.SetParamSimple(map, prefix + "IdNumber", this.IdNumber);
            this.SetParamSimple(map, prefix + "PhoneNumber", this.PhoneNumber);
            this.SetParamSimple(map, prefix + "Scene", this.Scene);
            this.SetParamSimple(map, prefix + "CustomerSubUin", this.CustomerSubUin);
            this.SetParamSimple(map, prefix + "Authorization", this.Authorization);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "BankCardNumber", this.BankCardNumber);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "Idfa", this.Idfa);
            this.SetParamSimple(map, prefix + "EmailAddress", this.EmailAddress);
            this.SetParamSimple(map, prefix + "Address", this.Address);
            this.SetParamSimple(map, prefix + "Mac", this.Mac);
            this.SetParamSimple(map, prefix + "Imsi", this.Imsi);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "AppIdU", this.AppIdU);
            this.SetParamSimple(map, prefix + "WifiMac", this.WifiMac);
            this.SetParamSimple(map, prefix + "WifiSSID", this.WifiSSID);
            this.SetParamSimple(map, prefix + "WifiBSSID", this.WifiBSSID);
            this.SetParamSimple(map, prefix + "ExtensionId", this.ExtensionId);
            this.SetParamSimple(map, prefix + "ExtensionIn", this.ExtensionIn);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "IdCryptoType", this.IdCryptoType);
            this.SetParamSimple(map, prefix + "PhoneCryptoType", this.PhoneCryptoType);
            this.SetParamSimple(map, prefix + "NameCryptoType", this.NameCryptoType);
            this.SetParamSimple(map, prefix + "OldResponseType", this.OldResponseType);
        }
    }
}

