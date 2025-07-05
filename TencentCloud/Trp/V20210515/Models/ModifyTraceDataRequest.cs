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

namespace TencentCloud.Trp.V20210515.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyTraceDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 溯源ID
        /// </summary>
        [JsonProperty("TraceId")]
        public string TraceId{ get; set; }

        /// <summary>
        /// 批次ID
        /// </summary>
        [JsonProperty("BatchId")]
        public string BatchId{ get; set; }

        /// <summary>
        /// 生产溯源任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 溯源信息
        /// </summary>
        [JsonProperty("TraceItems")]
        public TraceItem[] TraceItems{ get; set; }

        /// <summary>
        /// 溯源阶段名称
        /// </summary>
        [JsonProperty("PhaseName")]
        public string PhaseName{ get; set; }

        /// <summary>
        /// 环节数据
        /// </summary>
        [JsonProperty("PhaseData")]
        public PhaseData PhaseData{ get; set; }

        /// <summary>
        /// 溯源状态 0: 无效, 1: 有效
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 排序
        /// </summary>
        [JsonProperty("Rank")]
        public ulong? Rank{ get; set; }

        /// <summary>
        /// [无效] 类型
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// [无效] 溯源码
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// [无效] 溯源阶段 0:商品 1:通用 2:生产溯源 3:销售溯源
        /// </summary>
        [JsonProperty("Phase")]
        public ulong? Phase{ get; set; }

        /// <summary>
        /// [无效] 溯源时间
        /// </summary>
        [JsonProperty("TraceTime")]
        public string TraceTime{ get; set; }

        /// <summary>
        /// [无效] 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// [无效] 上链状态
        /// </summary>
        [JsonProperty("ChainStatus")]
        public ulong? ChainStatus{ get; set; }

        /// <summary>
        /// [无效] 上链时间
        /// </summary>
        [JsonProperty("ChainTime")]
        public string ChainTime{ get; set; }

        /// <summary>
        /// [无效] 上链数据
        /// </summary>
        [JsonProperty("ChainData")]
        public ChainData ChainData{ get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [JsonProperty("CorpId")]
        public ulong? CorpId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TraceId", this.TraceId);
            this.SetParamSimple(map, prefix + "BatchId", this.BatchId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamArrayObj(map, prefix + "TraceItems.", this.TraceItems);
            this.SetParamSimple(map, prefix + "PhaseName", this.PhaseName);
            this.SetParamObj(map, prefix + "PhaseData.", this.PhaseData);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Rank", this.Rank);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Phase", this.Phase);
            this.SetParamSimple(map, prefix + "TraceTime", this.TraceTime);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ChainStatus", this.ChainStatus);
            this.SetParamSimple(map, prefix + "ChainTime", this.ChainTime);
            this.SetParamObj(map, prefix + "ChainData.", this.ChainData);
            this.SetParamSimple(map, prefix + "CorpId", this.CorpId);
        }
    }
}

