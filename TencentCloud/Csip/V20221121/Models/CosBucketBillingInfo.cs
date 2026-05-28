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

    public class CosBucketBillingInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>appid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>uin</p>
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// <p>昵称</p>
        /// </summary>
        [JsonProperty("OwnerNickName")]
        public string OwnerNickName{ get; set; }

        /// <summary>
        /// <p>存储桶数量</p>
        /// </summary>
        [JsonProperty("BucketCount")]
        public ulong? BucketCount{ get; set; }

        /// <summary>
        /// <p>0 未购买 1  已单独购买 2 已被共享</p>
        /// </summary>
        [JsonProperty("BuyStatus")]
        public ulong? BuyStatus{ get; set; }

        /// <summary>
        /// <p>共享账号appid</p>
        /// </summary>
        [JsonProperty("ShareFromAppId")]
        public ulong? ShareFromAppId{ get; set; }

        /// <summary>
        /// <p>共享账号uin</p>
        /// </summary>
        [JsonProperty("ShareFromUin")]
        public string ShareFromUin{ get; set; }

        /// <summary>
        /// <p>共享账号昵称</p>
        /// </summary>
        [JsonProperty("ShareFromNickName")]
        public string ShareFromNickName{ get; set; }

        /// <summary>
        /// <p>监控的存储桶数</p>
        /// </summary>
        [JsonProperty("MonitorBucketCount")]
        public ulong? MonitorBucketCount{ get; set; }

        /// <summary>
        /// <p>0 关闭 1 开启</p>
        /// </summary>
        [JsonProperty("IsAutoMonitor")]
        public ulong? IsAutoMonitor{ get; set; }

        /// <summary>
        /// <p>是否启用白名单日志功能</p>
        /// </summary>
        [JsonProperty("LogFeatureWhitelist")]
        public bool? LogFeatureWhitelist{ get; set; }

        /// <summary>
        /// <p>是否存在新的后付费订单</p>
        /// </summary>
        [JsonProperty("IsHaveNewPostOrder")]
        public bool? IsHaveNewPostOrder{ get; set; }

        /// <summary>
        /// <p>是否存在旧后付费订单</p>
        /// </summary>
        [JsonProperty("IsHaveOldPostOrder")]
        public bool? IsHaveOldPostOrder{ get; set; }

        /// <summary>
        /// <p>后付费产品列表</p>
        /// </summary>
        [JsonProperty("PostProductList")]
        public long?[] PostProductList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "OwnerUin", this.OwnerUin);
            this.SetParamSimple(map, prefix + "OwnerNickName", this.OwnerNickName);
            this.SetParamSimple(map, prefix + "BucketCount", this.BucketCount);
            this.SetParamSimple(map, prefix + "BuyStatus", this.BuyStatus);
            this.SetParamSimple(map, prefix + "ShareFromAppId", this.ShareFromAppId);
            this.SetParamSimple(map, prefix + "ShareFromUin", this.ShareFromUin);
            this.SetParamSimple(map, prefix + "ShareFromNickName", this.ShareFromNickName);
            this.SetParamSimple(map, prefix + "MonitorBucketCount", this.MonitorBucketCount);
            this.SetParamSimple(map, prefix + "IsAutoMonitor", this.IsAutoMonitor);
            this.SetParamSimple(map, prefix + "LogFeatureWhitelist", this.LogFeatureWhitelist);
            this.SetParamSimple(map, prefix + "IsHaveNewPostOrder", this.IsHaveNewPostOrder);
            this.SetParamSimple(map, prefix + "IsHaveOldPostOrder", this.IsHaveOldPostOrder);
            this.SetParamArraySimple(map, prefix + "PostProductList.", this.PostProductList);
        }
    }
}

