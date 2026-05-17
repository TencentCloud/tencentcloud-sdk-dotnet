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
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// uin
        /// </summary>
        [JsonProperty("OwnerUin")]
        public string OwnerUin{ get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("OwnerNickName")]
        public string OwnerNickName{ get; set; }

        /// <summary>
        /// 存储桶数量
        /// </summary>
        [JsonProperty("BucketCount")]
        public ulong? BucketCount{ get; set; }

        /// <summary>
        /// 0 未购买 1  已单独购买 2 已被共享
        /// </summary>
        [JsonProperty("BuyStatus")]
        public ulong? BuyStatus{ get; set; }

        /// <summary>
        /// 共享账号appid
        /// </summary>
        [JsonProperty("ShareFromAppId")]
        public ulong? ShareFromAppId{ get; set; }

        /// <summary>
        /// 共享账号uin
        /// </summary>
        [JsonProperty("ShareFromUin")]
        public string ShareFromUin{ get; set; }

        /// <summary>
        /// 共享账号昵称
        /// </summary>
        [JsonProperty("ShareFromNickName")]
        public string ShareFromNickName{ get; set; }

        /// <summary>
        /// 监控的存储桶数
        /// </summary>
        [JsonProperty("MonitorBucketCount")]
        public ulong? MonitorBucketCount{ get; set; }

        /// <summary>
        /// 0 关闭 1 开启
        /// </summary>
        [JsonProperty("IsAutoMonitor")]
        public ulong? IsAutoMonitor{ get; set; }


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
        }
    }
}

