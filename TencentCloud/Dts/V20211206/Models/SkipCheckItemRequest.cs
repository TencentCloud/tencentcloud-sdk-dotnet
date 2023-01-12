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

    public class SkipCheckItemRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据迁移任务ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 需要跳过校验项的步骤id，需要通过DescribeMigrationCheckJob接口返回StepInfo[i].StepId字段获取，例如：["OptimizeCheck"]
        /// </summary>
        [JsonProperty("StepIds")]
        public string[] StepIds{ get; set; }

        /// <summary>
        /// 当出现外键依赖检查导致校验不通过时、可以通过该字段选择是否迁移外键依赖，当StepIds包含ConstraintCheck且该字段值为shield时表示不迁移外键依赖、当StepIds包含ConstraintCheck且值为migrate时表示迁移外键依赖
        /// </summary>
        [JsonProperty("ForeignKeyFlag")]
        public string ForeignKeyFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamArraySimple(map, prefix + "StepIds.", this.StepIds);
            this.SetParamSimple(map, prefix + "ForeignKeyFlag", this.ForeignKeyFlag);
        }
    }
}

