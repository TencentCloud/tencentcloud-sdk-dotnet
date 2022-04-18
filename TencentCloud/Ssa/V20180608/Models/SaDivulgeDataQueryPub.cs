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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SaDivulgeDataQueryPub : AbstractModel
    {
        
        /// <summary>
        /// Id信息
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 用户Uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 用户AppId
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }

        /// <summary>
        /// 事件名称
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// 监控源 0:全部 1:GitHub 2:暗网 默认值1
        /// </summary>
        [JsonProperty("DivulgeSoure")]
        public string DivulgeSoure{ get; set; }

        /// <summary>
        /// 受影响资产
        /// </summary>
        [JsonProperty("Asset")]
        public string Asset{ get; set; }

        /// <summary>
        /// 命中主题集下的规则topic名称
        /// </summary>
        [JsonProperty("RuleName")]
        public string RuleName{ get; set; }

        /// <summary>
        /// 命中主题集下的规则topic唯一id
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 命中主题集下的自定义规则策略
        /// </summary>
        [JsonProperty("RuleWord")]
        public string RuleWord{ get; set; }

        /// <summary>
        /// 扫描监测url
        /// </summary>
        [JsonProperty("ScanUrl")]
        public string ScanUrl{ get; set; }

        /// <summary>
        /// 扫描监测命中次数
        /// </summary>
        [JsonProperty("ScanCount")]
        public string ScanCount{ get; set; }

        /// <summary>
        /// 风险等级 -1:未知 1:低危 2:中危 3:高危 4:严重
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 安全事件处理状态 -1:未知 1:待处理 2:已处理 3:误报 4:已忽略 5:已知晓 6:已信任
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 安全事件发生时间
        /// </summary>
        [JsonProperty("EventTime")]
        public string EventTime{ get; set; }

        /// <summary>
        /// 事件插入时间
        /// </summary>
        [JsonProperty("InsertTime")]
        public string InsertTime{ get; set; }

        /// <summary>
        /// 事件更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "DivulgeSoure", this.DivulgeSoure);
            this.SetParamSimple(map, prefix + "Asset", this.Asset);
            this.SetParamSimple(map, prefix + "RuleName", this.RuleName);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "RuleWord", this.RuleWord);
            this.SetParamSimple(map, prefix + "ScanUrl", this.ScanUrl);
            this.SetParamSimple(map, prefix + "ScanCount", this.ScanCount);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "EventTime", this.EventTime);
            this.SetParamSimple(map, prefix + "InsertTime", this.InsertTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

