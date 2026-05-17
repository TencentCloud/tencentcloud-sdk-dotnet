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

    public class CosAuditPayInfo : AbstractModel
    {
        
        /// <summary>
        /// APPID
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 订单状态 0未购买 1正常，2隔离，3销毁，6试用中，7到期
        /// </summary>
        [JsonProperty("OrderStatus")]
        public ulong? OrderStatus{ get; set; }

        /// <summary>
        /// 已购对象存储数量
        /// </summary>
        [JsonProperty("BucketNum")]
        public ulong? BucketNum{ get; set; }

        /// <summary>
        /// 支付模式，0-后付费 1-预付费
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// 是否单独购买，1-单独购买，2-被其它账号共享
        /// </summary>
        [JsonProperty("IsSelfBuy")]
        public ulong? IsSelfBuy{ get; set; }

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
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// 订单时长
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

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
        public ulong? IsShareToOther{ get; set; }

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
        /// 共享的bucketIdSet 
        /// </summary>
        [JsonProperty("BindBucket")]
        public CosBucketId[] BindBucket{ get; set; }

        /// <summary>
        /// 共享的appid
        /// </summary>
        [JsonProperty("SharedAppIdSet")]
        public ulong?[] SharedAppIdSet{ get; set; }

        /// <summary>
        /// 是否已经开启后付费
        /// </summary>
        [JsonProperty("PostPayStatus")]
        public ulong? PostPayStatus{ get; set; }

        /// <summary>
        /// 0：未做过试用期试用   1 ：做过试用期试用
        /// </summary>
        [JsonProperty("IsTestUser")]
        public ulong? IsTestUser{ get; set; }

        /// <summary>
        /// 剩余可用数
        /// </summary>
        [JsonProperty("AvailableBucketNum")]
        public ulong? AvailableBucketNum{ get; set; }

        /// <summary>
        /// 已开启的监测存储桶数
        /// </summary>
        [JsonProperty("MonitorBucketNum")]
        public ulong? MonitorBucketNum{ get; set; }

        /// <summary>
        /// 总的存储桶数
        /// </summary>
        [JsonProperty("TotalBucketNum")]
        public ulong? TotalBucketNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "OrderStatus", this.OrderStatus);
            this.SetParamSimple(map, prefix + "BucketNum", this.BucketNum);
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
            this.SetParamArrayObj(map, prefix + "BindBucket.", this.BindBucket);
            this.SetParamArraySimple(map, prefix + "SharedAppIdSet.", this.SharedAppIdSet);
            this.SetParamSimple(map, prefix + "PostPayStatus", this.PostPayStatus);
            this.SetParamSimple(map, prefix + "IsTestUser", this.IsTestUser);
            this.SetParamSimple(map, prefix + "AvailableBucketNum", this.AvailableBucketNum);
            this.SetParamSimple(map, prefix + "MonitorBucketNum", this.MonitorBucketNum);
            this.SetParamSimple(map, prefix + "TotalBucketNum", this.TotalBucketNum);
        }
    }
}

