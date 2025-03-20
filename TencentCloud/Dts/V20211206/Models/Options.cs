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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Options : AbstractModel
    {
        
        /// <summary>
        /// 同步初始化选项，Data(全量数据初始化)、Structure(结构初始化)、Full(全量数据且结构初始化，默认)、None(仅增量)
        /// </summary>
        [JsonProperty("InitType")]
        public string InitType{ get; set; }

        /// <summary>
        /// 同名表的处理，ReportErrorAfterCheck(前置校验并报错，默认)、ExecuteAfterIgnore(忽略并继续执行)
        /// </summary>
        [JsonProperty("DealOfExistSameTable")]
        public string DealOfExistSameTable{ get; set; }

        /// <summary>
        /// 冲突处理选项，ReportError(报错，默认为该值)、Ignore(忽略)、Cover(覆盖)、ConditionCover(条件覆盖)
        /// </summary>
        [JsonProperty("ConflictHandleType")]
        public string ConflictHandleType{ get; set; }

        /// <summary>
        /// 是否添加附加列
        /// </summary>
        [JsonProperty("AddAdditionalColumn")]
        public bool? AddAdditionalColumn{ get; set; }

        /// <summary>
        /// 所要同步的DML和DDL的选项，Insert(插入操作)、Update(更新操作)、Delete(删除操作)、DDL(结构同步)， PartialDDL(自定义,和DdlOptions一起配合使用)。注意，这里至少需要包含DML中的一种。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OpTypes")]
        public string[] OpTypes{ get; set; }

        /// <summary>
        /// 冲突处理的详细选项，如条件覆盖中的条件行和条件操作
        /// </summary>
        [JsonProperty("ConflictHandleOption")]
        public ConflictHandleOption ConflictHandleOption{ get; set; }

        /// <summary>
        /// DDL同步选项，具体描述要同步那些DDL
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DdlOptions")]
        public DdlOption[] DdlOptions{ get; set; }

        /// <summary>
        /// kafka同步选项
        /// </summary>
        [JsonProperty("KafkaOption")]
        public KafkaOption KafkaOption{ get; set; }

        /// <summary>
        /// 任务限速信息
        /// </summary>
        [JsonProperty("RateLimitOption")]
        public RateLimitOption RateLimitOption{ get; set; }

        /// <summary>
        /// 自动重试的时间窗口设置
        /// </summary>
        [JsonProperty("AutoRetryTimeRangeMinutes")]
        public long? AutoRetryTimeRangeMinutes{ get; set; }

        /// <summary>
        /// 同步到kafka链路指定位点。目前只支持时间格式：2023-12-20T19:24:23+08:00。如果没有指定位点，为空。
        /// </summary>
        [JsonProperty("StartPosition")]
        public string StartPosition{ get; set; }

        /// <summary>
        /// 同步到kafka链路是否过滤掉begin和commit消息。目前仅mysql2kafka链路支持
        /// </summary>
        [JsonProperty("FilterBeginCommit")]
        public bool? FilterBeginCommit{ get; set; }

        /// <summary>
        /// 同步到kafka链路是否过滤掉checkpoint消息。目前仅mysql2kafka链路支持
        /// </summary>
        [JsonProperty("FilterCheckpoint")]
        public bool? FilterCheckpoint{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InitType", this.InitType);
            this.SetParamSimple(map, prefix + "DealOfExistSameTable", this.DealOfExistSameTable);
            this.SetParamSimple(map, prefix + "ConflictHandleType", this.ConflictHandleType);
            this.SetParamSimple(map, prefix + "AddAdditionalColumn", this.AddAdditionalColumn);
            this.SetParamArraySimple(map, prefix + "OpTypes.", this.OpTypes);
            this.SetParamObj(map, prefix + "ConflictHandleOption.", this.ConflictHandleOption);
            this.SetParamArrayObj(map, prefix + "DdlOptions.", this.DdlOptions);
            this.SetParamObj(map, prefix + "KafkaOption.", this.KafkaOption);
            this.SetParamObj(map, prefix + "RateLimitOption.", this.RateLimitOption);
            this.SetParamSimple(map, prefix + "AutoRetryTimeRangeMinutes", this.AutoRetryTimeRangeMinutes);
            this.SetParamSimple(map, prefix + "StartPosition", this.StartPosition);
            this.SetParamSimple(map, prefix + "FilterBeginCommit", this.FilterBeginCommit);
            this.SetParamSimple(map, prefix + "FilterCheckpoint", this.FilterCheckpoint);
        }
    }
}

