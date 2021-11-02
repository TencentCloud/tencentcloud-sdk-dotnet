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

    public class InputRecognizeTargetAudience : AbstractModel
    {
        
        /// <summary>
        /// 设备ID，AccountType指定的类型
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }

        /// <summary>
        /// 设备号类型，1.imei 2.imeiMd5（小写后转MD5转小写）3.idfa， 4.idfaMd5（大写后转MD5转小写），5.手机号,256.其它
        /// </summary>
        [JsonProperty("AccountType")]
        public long? AccountType{ get; set; }

        /// <summary>
        /// 模型ID列表
        /// </summary>
        [JsonProperty("ModelIdList")]
        public long?[] ModelIdList{ get; set; }

        /// <summary>
        /// 用户IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 操作系统类型(unknown，android，ios，windows)
        /// </summary>
        [JsonProperty("Os")]
        public string Os{ get; set; }

        /// <summary>
        /// 操作系统版本
        /// </summary>
        [JsonProperty("Osv")]
        public string Osv{ get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonProperty("Lat")]
        public string Lat{ get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonProperty("Lon")]
        public string Lon{ get; set; }

        /// <summary>
        /// 设备型号(MI 6)
        /// </summary>
        [JsonProperty("DeviceModel")]
        public string DeviceModel{ get; set; }

        /// <summary>
        /// 竞价底价
        /// </summary>
        [JsonProperty("BidFloor")]
        public long? BidFloor{ get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        [JsonProperty("Age")]
        public long? Age{ get; set; }

        /// <summary>
        /// 性别(1.MALE 2.FEMALE)
        /// </summary>
        [JsonProperty("Gender")]
        public long? Gender{ get; set; }

        /// <summary>
        /// 用户地址
        /// </summary>
        [JsonProperty("Location")]
        public string Location{ get; set; }

        /// <summary>
        /// 投放模式（0=PDB，1=PD，2=RTB，10=其他）
        /// </summary>
        [JsonProperty("DeliveryMode")]
        public long? DeliveryMode{ get; set; }

        /// <summary>
        /// 广告位类型<br />（0=前贴片，1=开屏广告，2=网页头部广告、3=网页中部广告、4=网页底部广告、5=悬浮广告、10=其它）
        /// </summary>
        [JsonProperty("AdvertisingType")]
        public long? AdvertisingType{ get; set; }

        /// <summary>
        /// mac地址，建议提供
        /// </summary>
        [JsonProperty("Mac")]
        public string Mac{ get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

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
        [JsonProperty("Package")]
        public string Package{ get; set; }

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
        /// 入网方式(wifi,4g,3g,2g)
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// 运营商(1.移动 2.联通 3.电信等)
        /// </summary>
        [JsonProperty("Sp")]
        public long? Sp{ get; set; }

        /// <summary>
        /// 设备屏幕分辨率宽度像素数
        /// </summary>
        [JsonProperty("DeviceW")]
        public long? DeviceW{ get; set; }

        /// <summary>
        /// 设备屏幕分辨率高度像素数
        /// </summary>
        [JsonProperty("DeviceH")]
        public long? DeviceH{ get; set; }

        /// <summary>
        /// 是否全屏插广告(0-否，1-是)
        /// </summary>
        [JsonProperty("FullScreen")]
        public long? FullScreen{ get; set; }

        /// <summary>
        /// 广告位宽度
        /// </summary>
        [JsonProperty("ImpBannerW")]
        public long? ImpBannerW{ get; set; }

        /// <summary>
        /// 广告位高度
        /// </summary>
        [JsonProperty("ImpBannerH")]
        public long? ImpBannerH{ get; set; }

        /// <summary>
        /// 网址
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// 上下文信息
        /// </summary>
        [JsonProperty("Context")]
        public string Context{ get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [JsonProperty("Channel")]
        public string Channel{ get; set; }

        /// <summary>
        /// 请求ID
        /// </summary>
        [JsonProperty("ReqId")]
        public string ReqId{ get; set; }

        /// <summary>
        /// 请求ID的md5值
        /// </summary>
        [JsonProperty("ReqMd5")]
        public string ReqMd5{ get; set; }

        /// <summary>
        /// ad_type
        /// </summary>
        [JsonProperty("AdType")]
        public long? AdType{ get; set; }

        /// <summary>
        /// app名称
        /// </summary>
        [JsonProperty("AppName")]
        public string AppName{ get; set; }

        /// <summary>
        /// app版本描述
        /// </summary>
        [JsonProperty("AppVer")]
        public string AppVer{ get; set; }

        /// <summary>
        /// 竞价模式1：rtb 2:pd
        /// </summary>
        [JsonProperty("ReqType")]
        public long? ReqType{ get; set; }

        /// <summary>
        /// 用户是否授权,1为授权，0为未授权
        /// </summary>
        [JsonProperty("IsAuthorized")]
        public ulong? IsAuthorized{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamArraySimple(map, prefix + "ModelIdList.", this.ModelIdList);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Os", this.Os);
            this.SetParamSimple(map, prefix + "Osv", this.Osv);
            this.SetParamSimple(map, prefix + "Lat", this.Lat);
            this.SetParamSimple(map, prefix + "Lon", this.Lon);
            this.SetParamSimple(map, prefix + "DeviceModel", this.DeviceModel);
            this.SetParamSimple(map, prefix + "BidFloor", this.BidFloor);
            this.SetParamSimple(map, prefix + "Age", this.Age);
            this.SetParamSimple(map, prefix + "Gender", this.Gender);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "DeliveryMode", this.DeliveryMode);
            this.SetParamSimple(map, prefix + "AdvertisingType", this.AdvertisingType);
            this.SetParamSimple(map, prefix + "Mac", this.Mac);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "Ua", this.Ua);
            this.SetParamSimple(map, prefix + "App", this.App);
            this.SetParamSimple(map, prefix + "Package", this.Package);
            this.SetParamSimple(map, prefix + "Maker", this.Maker);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "Sp", this.Sp);
            this.SetParamSimple(map, prefix + "DeviceW", this.DeviceW);
            this.SetParamSimple(map, prefix + "DeviceH", this.DeviceH);
            this.SetParamSimple(map, prefix + "FullScreen", this.FullScreen);
            this.SetParamSimple(map, prefix + "ImpBannerW", this.ImpBannerW);
            this.SetParamSimple(map, prefix + "ImpBannerH", this.ImpBannerH);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "Context", this.Context);
            this.SetParamSimple(map, prefix + "Channel", this.Channel);
            this.SetParamSimple(map, prefix + "ReqId", this.ReqId);
            this.SetParamSimple(map, prefix + "ReqMd5", this.ReqMd5);
            this.SetParamSimple(map, prefix + "AdType", this.AdType);
            this.SetParamSimple(map, prefix + "AppName", this.AppName);
            this.SetParamSimple(map, prefix + "AppVer", this.AppVer);
            this.SetParamSimple(map, prefix + "ReqType", this.ReqType);
            this.SetParamSimple(map, prefix + "IsAuthorized", this.IsAuthorized);
        }
    }
}

