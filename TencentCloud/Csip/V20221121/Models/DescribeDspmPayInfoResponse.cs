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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDspmPayInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// APPID
        /// </summary>
        [JsonProperty("AppID")]
        public long? AppID{ get; set; }

        /// <summary>
        /// 订单状态 0未购买 1正常，2隔离，3销毁，6试用中，7到期
        /// </summary>
        [JsonProperty("OrderStatus")]
        public long? OrderStatus{ get; set; }

        /// <summary>
        /// 已购数据库实例数量
        /// </summary>
        [JsonProperty("AssetNum")]
        public long? AssetNum{ get; set; }

        /// <summary>
        /// 已购审计日志量（TB）
        /// </summary>
        [JsonProperty("LogStorage")]
        public float? LogStorage{ get; set; }

        /// <summary>
        /// 已使用数据库实例数量
        /// </summary>
        [JsonProperty("UsedAssetNum")]
        public long? UsedAssetNum{ get; set; }

        /// <summary>
        /// 已使用审计日志量（TB）
        /// </summary>
        [JsonProperty("UsedLogStorage")]
        public float? UsedLogStorage{ get; set; }

        /// <summary>
        /// 已购sql存储总量（单位百万）
        /// </summary>
        [JsonProperty("SqlTotal")]
        public ulong? SqlTotal{ get; set; }

        /// <summary>
        /// 已购sql qps
        /// </summary>
        [JsonProperty("SqlQps")]
        public ulong? SqlQps{ get; set; }

        /// <summary>
        /// 支付模式，0-后付费 1-预付费
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 是否单独购买，1-单独购买，2-被其它账号共享
        /// </summary>
        [JsonProperty("IsSelfBuy")]
        public long? IsSelfBuy{ get; set; }

        /// <summary>
        /// 订单开始时间
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// 订单到期时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 0-用户未设置,1-用户设置自动续费,2-用户设置不自动续费
        /// </summary>
        [JsonProperty("AutoRenew")]
        public long? AutoRenew{ get; set; }

        /// <summary>
        /// 订单时长
        /// </summary>
        [JsonProperty("TimeSpan")]
        public long? TimeSpan{ get; set; }

        /// <summary>
        /// 时长单位
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// 资源id
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 公测结束时间
        /// </summary>
        [JsonProperty("BetaEndTime")]
        public string BetaEndTime{ get; set; }

        /// <summary>
        /// 系统当前时间
        /// </summary>
        [JsonProperty("TimeNow")]
        public string TimeNow{ get; set; }

        /// <summary>
        /// 是否分享给其它账号，1-是，2-否
        /// </summary>
        [JsonProperty("IsShareToOther")]
        public long? IsShareToOther{ get; set; }

        /// <summary>
        /// uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 购买信息
        /// </summary>
        [JsonProperty("InquireData")]
        public InquireInfo[] InquireData{ get; set; }

        /// <summary>
        /// 版本(专业版：professional 试用版：trial)
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "OrderStatus", this.OrderStatus);
            this.SetParamSimple(map, prefix + "AssetNum", this.AssetNum);
            this.SetParamSimple(map, prefix + "LogStorage", this.LogStorage);
            this.SetParamSimple(map, prefix + "UsedAssetNum", this.UsedAssetNum);
            this.SetParamSimple(map, prefix + "UsedLogStorage", this.UsedLogStorage);
            this.SetParamSimple(map, prefix + "SqlTotal", this.SqlTotal);
            this.SetParamSimple(map, prefix + "SqlQps", this.SqlQps);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "IsSelfBuy", this.IsSelfBuy);
            this.SetParamSimple(map, prefix + "BeginTime", this.BeginTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamSimple(map, prefix + "TimeSpan", this.TimeSpan);
            this.SetParamSimple(map, prefix + "TimeUnit", this.TimeUnit);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "BetaEndTime", this.BetaEndTime);
            this.SetParamSimple(map, prefix + "TimeNow", this.TimeNow);
            this.SetParamSimple(map, prefix + "IsShareToOther", this.IsShareToOther);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamArrayObj(map, prefix + "InquireData.", this.InquireData);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

