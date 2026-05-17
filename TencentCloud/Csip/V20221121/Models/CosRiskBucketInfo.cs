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

    public class CosRiskBucketInfo : AbstractModel
    {
        
        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 桶名
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// 桶地域
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// 桶备注信息
        /// </summary>
        [JsonProperty("BucketMarker")]
        public string BucketMarker{ get; set; }

        /// <summary>
        /// 桶uin
        /// </summary>
        [JsonProperty("BucketUin")]
        public string BucketUin{ get; set; }

        /// <summary>
        /// uin昵称
        /// </summary>
        [JsonProperty("BucketNickName")]
        public string BucketNickName{ get; set; }

        /// <summary>
        /// uin主账号昵称
        /// </summary>
        [JsonProperty("BucketMainNickName")]
        public string BucketMainNickName{ get; set; }

        /// <summary>
        /// uin身份
        /// </summary>
        [JsonProperty("BucketIdentify")]
        public long? BucketIdentify{ get; set; }

        /// <summary>
        /// 风险检出时间Unix时间单位毫秒
        /// </summary>
        [JsonProperty("LastScanTimestamp")]
        public long? LastScanTimestamp{ get; set; }

        /// <summary>
        /// 状态信息
        /// </summary>
        [JsonProperty("HandleStatus")]
        public long? HandleStatus{ get; set; }

        /// <summary>
        /// 风险名称
        /// </summary>
        [JsonProperty("PolicyName")]
        public string PolicyName{ get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [JsonProperty("PolicyType")]
        public long? PolicyType{ get; set; }

        /// <summary>
        /// 策略id
        /// </summary>
        [JsonProperty("PolicyId")]
        public long? PolicyId{ get; set; }

        /// <summary>
        /// 策略级别
        /// </summary>
        [JsonProperty("PolicyLevel")]
        public long? PolicyLevel{ get; set; }

        /// <summary>
        /// 策略描述
        /// </summary>
        [JsonProperty("PolicyDescription")]
        public string PolicyDescription{ get; set; }

        /// <summary>
        /// 访问方式
        /// </summary>
        [JsonProperty("BucketAccessWay")]
        public string BucketAccessWay{ get; set; }

        /// <summary>
        /// 标签信息
        /// </summary>
        [JsonProperty("BucketTagInfo")]
        public string BucketTagInfo{ get; set; }

        /// <summary>
        /// 风险id
        /// </summary>
        [JsonProperty("RiskId")]
        public long? RiskId{ get; set; }

        /// <summary>
        /// cos地域码值
        /// </summary>
        [JsonProperty("BucketRegionCode")]
        public string BucketRegionCode{ get; set; }

        /// <summary>
        /// 是否开启自动监测状态 0 关闭 1 开启
        /// </summary>
        [JsonProperty("BucketMonitorStatus")]
        public ulong? BucketMonitorStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "BucketMarker", this.BucketMarker);
            this.SetParamSimple(map, prefix + "BucketUin", this.BucketUin);
            this.SetParamSimple(map, prefix + "BucketNickName", this.BucketNickName);
            this.SetParamSimple(map, prefix + "BucketMainNickName", this.BucketMainNickName);
            this.SetParamSimple(map, prefix + "BucketIdentify", this.BucketIdentify);
            this.SetParamSimple(map, prefix + "LastScanTimestamp", this.LastScanTimestamp);
            this.SetParamSimple(map, prefix + "HandleStatus", this.HandleStatus);
            this.SetParamSimple(map, prefix + "PolicyName", this.PolicyName);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyLevel", this.PolicyLevel);
            this.SetParamSimple(map, prefix + "PolicyDescription", this.PolicyDescription);
            this.SetParamSimple(map, prefix + "BucketAccessWay", this.BucketAccessWay);
            this.SetParamSimple(map, prefix + "BucketTagInfo", this.BucketTagInfo);
            this.SetParamSimple(map, prefix + "RiskId", this.RiskId);
            this.SetParamSimple(map, prefix + "BucketRegionCode", this.BucketRegionCode);
            this.SetParamSimple(map, prefix + "BucketMonitorStatus", this.BucketMonitorStatus);
        }
    }
}

