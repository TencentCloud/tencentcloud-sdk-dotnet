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
        /// <p>APPID</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>订单状态 0未购买 1正常，2隔离，3销毁，6试用中，7到期</p>
        /// </summary>
        [JsonProperty("OrderStatus")]
        public ulong? OrderStatus{ get; set; }

        /// <summary>
        /// <p>已购对象存储数量</p>
        /// </summary>
        [JsonProperty("BucketNum")]
        public ulong? BucketNum{ get; set; }

        /// <summary>
        /// <p>支付模式，0-后付费 1-预付费</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public ulong? PayMode{ get; set; }

        /// <summary>
        /// <p>是否单独购买，1-单独购买，2-被其它账号共享</p>
        /// </summary>
        [JsonProperty("IsSelfBuy")]
        public ulong? IsSelfBuy{ get; set; }

        /// <summary>
        /// <p>订单开始时间</p>
        /// </summary>
        [JsonProperty("BeginTime")]
        public string BeginTime{ get; set; }

        /// <summary>
        /// <p>订单到期时间</p>
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// <p>0-用户未设置,1-用户设置自动续费,2-用户设置不自动续费</p>
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// <p>订单时长</p>
        /// </summary>
        [JsonProperty("TimeSpan")]
        public ulong? TimeSpan{ get; set; }

        /// <summary>
        /// <p>时长单位</p>
        /// </summary>
        [JsonProperty("TimeUnit")]
        public string TimeUnit{ get; set; }

        /// <summary>
        /// <p>资源id</p>
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// <p>公测结束时间</p>
        /// </summary>
        [JsonProperty("BetaEndTime")]
        public string BetaEndTime{ get; set; }

        /// <summary>
        /// <p>系统当前时间</p>
        /// </summary>
        [JsonProperty("TimeNow")]
        public string TimeNow{ get; set; }

        /// <summary>
        /// <p>是否分享给其它账号，1-是，2-否</p>
        /// </summary>
        [JsonProperty("IsShareToOther")]
        public ulong? IsShareToOther{ get; set; }

        /// <summary>
        /// <p>uin</p>
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>昵称</p>
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// <p>共享的bucketIdSet</p>
        /// </summary>
        [JsonProperty("BindBucket")]
        public CosBucketId[] BindBucket{ get; set; }

        /// <summary>
        /// <p>共享的appid</p>
        /// </summary>
        [JsonProperty("SharedAppIdSet")]
        public ulong?[] SharedAppIdSet{ get; set; }

        /// <summary>
        /// <p>是否已经开启后付费</p>
        /// </summary>
        [JsonProperty("PostPayStatus")]
        public ulong? PostPayStatus{ get; set; }

        /// <summary>
        /// <p>0：未做过试用期试用   1 ：做过试用期试用</p>
        /// </summary>
        [JsonProperty("IsTestUser")]
        public ulong? IsTestUser{ get; set; }

        /// <summary>
        /// <p>剩余可用数</p>
        /// </summary>
        [JsonProperty("AvailableBucketNum")]
        public ulong? AvailableBucketNum{ get; set; }

        /// <summary>
        /// <p>已开启的监测存储桶数</p>
        /// </summary>
        [JsonProperty("MonitorBucketNum")]
        public ulong? MonitorBucketNum{ get; set; }

        /// <summary>
        /// <p>总的存储桶数</p>
        /// </summary>
        [JsonProperty("TotalBucketNum")]
        public ulong? TotalBucketNum{ get; set; }

        /// <summary>
        /// <p>后付费产品开关状态</p>
        /// </summary>
        [JsonProperty("PostProductStatusList")]
        public ulong?[] PostProductStatusList{ get; set; }

        /// <summary>
        /// <p>后付费产品购买状态</p>
        /// </summary>
        [JsonProperty("PostProductBuyStatusList")]
        public ulong?[] PostProductBuyStatusList{ get; set; }

        /// <summary>
        /// <p>新后付费资源id</p>
        /// </summary>
        [JsonProperty("NewPostPayResourceId")]
        public string NewPostPayResourceId{ get; set; }


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
            this.SetParamArraySimple(map, prefix + "PostProductStatusList.", this.PostProductStatusList);
            this.SetParamArraySimple(map, prefix + "PostProductBuyStatusList.", this.PostProductBuyStatusList);
            this.SetParamSimple(map, prefix + "NewPostPayResourceId", this.NewPostPayResourceId);
        }
    }
}

