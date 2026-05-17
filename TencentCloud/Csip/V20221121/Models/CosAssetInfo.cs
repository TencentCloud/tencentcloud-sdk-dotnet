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

    public class CosAssetInfo : AbstractModel
    {
        
        /// <summary>
        /// appid
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// cos桶名
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// cos region名
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// 地域码值
        /// </summary>
        [JsonProperty("BucketRegionCode")]
        public string BucketRegionCode{ get; set; }

        /// <summary>
        /// cos桶备注
        /// </summary>
        [JsonProperty("BucketMarker")]
        public string BucketMarker{ get; set; }

        /// <summary>
        /// cos桶主账号所属者
        /// </summary>
        [JsonProperty("BucketOwnerUin")]
        public string BucketOwnerUin{ get; set; }

        /// <summary>
        /// cos主账号所属者昵称
        /// </summary>
        [JsonProperty("BucketOwnerNickName")]
        public string BucketOwnerNickName{ get; set; }

        /// <summary>
        /// cos桶标签详情
        /// </summary>
        [JsonProperty("BucketTagInfo")]
        public string BucketTagInfo{ get; set; }

        /// <summary>
        /// 安全建议
        /// 1 暂无异常
        /// 2 建议加固
        /// 3 立即处理
        /// </summary>
        [JsonProperty("BucketSecuritySuggestion")]
        public long? BucketSecuritySuggestion{ get; set; }

        /// <summary>
        /// 告警列表
        /// </summary>
        [JsonProperty("BucketAlarmList")]
        public CosRiskAlarmInfo[] BucketAlarmList{ get; set; }

        /// <summary>
        /// 风险列表
        /// </summary>
        [JsonProperty("BucketRiskList")]
        public CosRiskAlarmInfo[] BucketRiskList{ get; set; }

        /// <summary>
        /// 调用源ip数
        /// </summary>
        [JsonProperty("BucketInvokeSourceIpCount")]
        public long? BucketInvokeSourceIpCount{ get; set; }

        /// <summary>
        /// 访问策略
        /// </summary>
        [JsonProperty("BucketAccessWay")]
        public CosBucketAccessWay BucketAccessWay{ get; set; }

        /// <summary>
        /// 创建时间Unix时间单位毫秒
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 最后访问时间Unix时间单位毫秒
        /// </summary>
        [JsonProperty("LastAccessTime")]
        public long? LastAccessTime{ get; set; }

        /// <summary>
        /// 存储桶id
        /// </summary>
        [JsonProperty("BucketId")]
        public ulong? BucketId{ get; set; }

        /// <summary>
        /// 0 关闭
        /// 1 开启
        /// </summary>
        [JsonProperty("MonitorStatus")]
        public ulong? MonitorStatus{ get; set; }

        /// <summary>
        /// 数据识别扫描信息
        /// </summary>
        [JsonProperty("DataScanInfo")]
        public CosAssetDataScanDetail DataScanInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "BucketName", this.BucketName);
            this.SetParamSimple(map, prefix + "BucketRegion", this.BucketRegion);
            this.SetParamSimple(map, prefix + "BucketRegionCode", this.BucketRegionCode);
            this.SetParamSimple(map, prefix + "BucketMarker", this.BucketMarker);
            this.SetParamSimple(map, prefix + "BucketOwnerUin", this.BucketOwnerUin);
            this.SetParamSimple(map, prefix + "BucketOwnerNickName", this.BucketOwnerNickName);
            this.SetParamSimple(map, prefix + "BucketTagInfo", this.BucketTagInfo);
            this.SetParamSimple(map, prefix + "BucketSecuritySuggestion", this.BucketSecuritySuggestion);
            this.SetParamArrayObj(map, prefix + "BucketAlarmList.", this.BucketAlarmList);
            this.SetParamArrayObj(map, prefix + "BucketRiskList.", this.BucketRiskList);
            this.SetParamSimple(map, prefix + "BucketInvokeSourceIpCount", this.BucketInvokeSourceIpCount);
            this.SetParamObj(map, prefix + "BucketAccessWay.", this.BucketAccessWay);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "LastAccessTime", this.LastAccessTime);
            this.SetParamSimple(map, prefix + "BucketId", this.BucketId);
            this.SetParamSimple(map, prefix + "MonitorStatus", this.MonitorStatus);
            this.SetParamObj(map, prefix + "DataScanInfo.", this.DataScanInfo);
        }
    }
}

