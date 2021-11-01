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

namespace TencentCloud.Taf.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputTaBspData : AbstractModel
    {
        
        /// <summary>
        /// 请求序列号
        /// </summary>
        [JsonProperty("Seq")]
        public long? Seq{ get; set; }

        /// <summary>
        /// 操作系统类型[0：未知；1：android；2：ios；3：windows]
        /// </summary>
        [JsonProperty("OsType")]
        public string OsType{ get; set; }

        /// <summary>
        /// 年龄下限
        /// </summary>
        [JsonProperty("AgeFloor")]
        public long? AgeFloor{ get; set; }

        /// <summary>
        /// 年龄上限
        /// </summary>
        [JsonProperty("AgeCeil")]
        public long? AgeCeil{ get; set; }

        /// <summary>
        /// 性别[1：男；2：女]
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }

        /// <summary>
        /// 用户操作时间,uinux时间戳，精确到秒
        /// </summary>
        [JsonProperty("UserTime")]
        public long? UserTime{ get; set; }

        /// <summary>
        /// Imei [在(Imei|ImeiMd5|Idfa|IdfaMd5)里面4选1]
        /// </summary>
        [JsonProperty("Imei")]
        public string Imei{ get; set; }

        /// <summary>
        /// Imei小写后加密Md5 [在(Imei|ImeiMd5|Idfa|IdfaMd5)里面4选1]
        /// </summary>
        [JsonProperty("ImeiMd5")]
        public string ImeiMd5{ get; set; }

        /// <summary>
        /// Idfa [在(Imei|ImeiMd5|Idfa|IdfaMd5)里面4选1]
        /// </summary>
        [JsonProperty("Idfa")]
        public string Idfa{ get; set; }

        /// <summary>
        /// Idfa大写后加密Md5 [在(Imei|ImeiMd5|Idfa|IdfaMd5)里面4选1]
        /// </summary>
        [JsonProperty("IdfaMd5")]
        public string IdfaMd5{ get; set; }

        /// <summary>
        /// 用户IP
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// MAC地址[建议提供]
        /// </summary>
        [JsonProperty("Mac")]
        public string Mac{ get; set; }

        /// <summary>
        /// 手机号码[中国大陆]
        /// </summary>
        [JsonProperty("PhoneNum")]
        public string PhoneNum{ get; set; }

        /// <summary>
        /// 浏览器
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// APP名称
        /// </summary>
        [JsonProperty("App")]
        public string App{ get; set; }

        /// <summary>
        /// 应用安装包名称
        /// </summary>
        [JsonProperty("Package")]
        public string Package{ get; set; }

        /// <summary>
        /// 设备制造商
        /// </summary>
        [JsonProperty("DeviceMaker")]
        public string DeviceMaker{ get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        [JsonProperty("DeviceModule")]
        public string DeviceModule{ get; set; }

        /// <summary>
        /// 入网方式[1：WIFI；2：4G；3：3G；4：2G；5：其它]
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// 运营商[1：移动；2：联通；3：电信；4：其它]
        /// </summary>
        [JsonProperty("Sp")]
        public string Sp{ get; set; }

        /// <summary>
        /// 网址
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 用户地址
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("Latitude")]
        public string Latitude{ get; set; }

        /// <summary>
        /// 精度
        /// </summary>
        [JsonProperty("Longitude")]
        public string Longitude{ get; set; }

        /// <summary>
        /// 辅助区分信息
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 是否授权
        /// </summary>
        [JsonProperty("IsAuthorized")]
        public ulong? IsAuthorized{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Seq", this.Seq);
            this.SetParamSimple(map, prefix + "OsType", this.OsType);
            this.SetParamSimple(map, prefix + "AgeFloor", this.AgeFloor);
            this.SetParamSimple(map, prefix + "AgeCeil", this.AgeCeil);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "UserTime", this.UserTime);
            this.SetParamSimple(map, prefix + "Imei", this.Imei);
            this.SetParamSimple(map, prefix + "ImeiMd5", this.ImeiMd5);
            this.SetParamSimple(map, prefix + "Idfa", this.Idfa);
            this.SetParamSimple(map, prefix + "IdfaMd5", this.IdfaMd5);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "Mac", this.Mac);
            this.SetParamSimple(map, prefix + "PhoneNum", this.PhoneNum);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "App", this.App);
            this.SetParamSimple(map, prefix + "Package", this.Package);
            this.SetParamSimple(map, prefix + "DeviceMaker", this.DeviceMaker);
            this.SetParamSimple(map, prefix + "DeviceModule", this.DeviceModule);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "Sp", this.Sp);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "Latitude", this.Latitude);
            this.SetParamSimple(map, prefix + "Longitude", this.Longitude);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "IsAuthorized", this.IsAuthorized);
        }
    }
}

