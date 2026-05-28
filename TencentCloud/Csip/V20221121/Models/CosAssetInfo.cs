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
        /// <p>appid</p>
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>cos桶名</p>
        /// </summary>
        [JsonProperty("BucketName")]
        public string BucketName{ get; set; }

        /// <summary>
        /// <p>cos region名</p>
        /// </summary>
        [JsonProperty("BucketRegion")]
        public string BucketRegion{ get; set; }

        /// <summary>
        /// <p>地域码值</p>
        /// </summary>
        [JsonProperty("BucketRegionCode")]
        public string BucketRegionCode{ get; set; }

        /// <summary>
        /// <p>cos桶备注</p>
        /// </summary>
        [JsonProperty("BucketMarker")]
        public string BucketMarker{ get; set; }

        /// <summary>
        /// <p>cos桶主账号所属者</p>
        /// </summary>
        [JsonProperty("BucketOwnerUin")]
        public string BucketOwnerUin{ get; set; }

        /// <summary>
        /// <p>cos主账号所属者昵称</p>
        /// </summary>
        [JsonProperty("BucketOwnerNickName")]
        public string BucketOwnerNickName{ get; set; }

        /// <summary>
        /// <p>cos桶标签详情</p>
        /// </summary>
        [JsonProperty("BucketTagInfo")]
        public string BucketTagInfo{ get; set; }

        /// <summary>
        /// <p>安全建议<br>1 暂无异常<br>2 建议加固<br>3 立即处理</p>
        /// </summary>
        [JsonProperty("BucketSecuritySuggestion")]
        public long? BucketSecuritySuggestion{ get; set; }

        /// <summary>
        /// <p>告警列表</p>
        /// </summary>
        [JsonProperty("BucketAlarmList")]
        public CosRiskAlarmInfo[] BucketAlarmList{ get; set; }

        /// <summary>
        /// <p>风险列表</p>
        /// </summary>
        [JsonProperty("BucketRiskList")]
        public CosRiskAlarmInfo[] BucketRiskList{ get; set; }

        /// <summary>
        /// <p>调用源ip数</p>
        /// </summary>
        [JsonProperty("BucketInvokeSourceIpCount")]
        public long? BucketInvokeSourceIpCount{ get; set; }

        /// <summary>
        /// <p>访问策略</p>
        /// </summary>
        [JsonProperty("BucketAccessWay")]
        public CosBucketAccessWay BucketAccessWay{ get; set; }

        /// <summary>
        /// <p>创建时间Unix时间单位毫秒</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// <p>最后访问时间Unix时间单位毫秒</p>
        /// </summary>
        [JsonProperty("LastAccessTime")]
        public long? LastAccessTime{ get; set; }

        /// <summary>
        /// <p>存储桶id</p>
        /// </summary>
        [JsonProperty("BucketId")]
        public ulong? BucketId{ get; set; }

        /// <summary>
        /// <p>0 关闭<br>1 开启</p>
        /// </summary>
        [JsonProperty("MonitorStatus")]
        public ulong? MonitorStatus{ get; set; }

        /// <summary>
        /// <p>数据识别扫描信息</p>
        /// </summary>
        [JsonProperty("DataScanInfo")]
        public CosAssetDataScanDetail DataScanInfo{ get; set; }

        /// <summary>
        /// <p>存储桶Az类型</p><p>枚举值：</p><ul><li>MAZ： 多az</li><li>SAZ： 单az</li></ul>
        /// </summary>
        [JsonProperty("BucketAzType")]
        public string BucketAzType{ get; set; }

        /// <summary>
        /// <p>存储桶存储大小</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("BucketStorageSize")]
        public long? BucketStorageSize{ get; set; }

        /// <summary>
        /// <p>存储桶对象个数</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("BucketObjectCount")]
        public long? BucketObjectCount{ get; set; }

        /// <summary>
        /// <p>存储桶敏感识别采样率</p><p>取值范围：[0, 1]</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("IdentifySampleRate")]
        public float? IdentifySampleRate{ get; set; }


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
            this.SetParamSimple(map, prefix + "BucketAzType", this.BucketAzType);
            this.SetParamSimple(map, prefix + "BucketStorageSize", this.BucketStorageSize);
            this.SetParamSimple(map, prefix + "BucketObjectCount", this.BucketObjectCount);
            this.SetParamSimple(map, prefix + "IdentifySampleRate", this.IdentifySampleRate);
        }
    }
}

