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

    public class DynamicOptions : AbstractModel
    {
        
        /// <summary>
        /// 所要同步的DML和DDL的选项，Insert(插入操作)、Update(更新操作)、Delete(删除操作)、DDL(结构同步)，PartialDDL(自定义,和DdlOptions一起起作用 )；必填、dts会用该值覆盖原有的值
        /// </summary>
        [JsonProperty("OpTypes")]
        public string[] OpTypes{ get; set; }

        /// <summary>
        /// DDL同步选项，具体描述要同步那些DDL; 当OpTypes取值PartialDDL时、字段不能为空；必填、dts会用该值覆盖原有的值
        /// </summary>
        [JsonProperty("DdlOptions")]
        public DdlOption[] DdlOptions{ get; set; }

        /// <summary>
        /// 冲突处理选项，ReportError(报错)、Ignore(忽略)、Cover(覆盖)、ConditionCover(条件覆盖); 目前目标端为kafka的链路不支持修改该配置
        /// </summary>
        [JsonProperty("ConflictHandleType")]
        public string ConflictHandleType{ get; set; }

        /// <summary>
        /// 冲突处理的详细选项，如条件覆盖中的条件行和条件操作；不能部分更新该选项的内部字段；有更新时、需要全量更新该字段
        /// </summary>
        [JsonProperty("ConflictHandleOption")]
        public ConflictHandleOption ConflictHandleOption{ get; set; }

        /// <summary>
        /// 同步到kafka链路的kafka配置
        /// </summary>
        [JsonProperty("KafkaOption")]
        public KafkaOption KafkaOption{ get; set; }

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
        /// 同名表的处理，ReportErrorAfterCheck(前置校验并报错，默认)、ExecuteAfterIgnore(忽略并继续执行)
        /// </summary>
        [JsonProperty("DealOfExistSameTable")]
        public string DealOfExistSameTable{ get; set; }

        /// <summary>
        /// 仅增量任务重新设置指定位点
        /// </summary>
        [JsonProperty("StartPosition")]
        public string StartPosition{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "OpTypes.", this.OpTypes);
            this.SetParamArrayObj(map, prefix + "DdlOptions.", this.DdlOptions);
            this.SetParamSimple(map, prefix + "ConflictHandleType", this.ConflictHandleType);
            this.SetParamObj(map, prefix + "ConflictHandleOption.", this.ConflictHandleOption);
            this.SetParamObj(map, prefix + "KafkaOption.", this.KafkaOption);
            this.SetParamSimple(map, prefix + "FilterBeginCommit", this.FilterBeginCommit);
            this.SetParamSimple(map, prefix + "FilterCheckpoint", this.FilterCheckpoint);
            this.SetParamSimple(map, prefix + "DealOfExistSameTable", this.DealOfExistSameTable);
            this.SetParamSimple(map, prefix + "StartPosition", this.StartPosition);
        }
    }
}

