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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyProgramRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据集ID
        /// </summary>
        [JsonProperty("ProgramId")]
        public string ProgramId{ get; set; }

        /// <summary>
        /// 数据集名称，不传入时不更新
        /// </summary>
        [JsonProperty("ProgramName")]
        public string ProgramName{ get; set; }

        /// <summary>
        /// 数据集描述，不传入时不更新
        /// </summary>
        [JsonProperty("ProgramDesc")]
        public string ProgramDesc{ get; set; }

        /// <summary>
        /// 数据项列表，传入null不更新，传入空数组全量删除
        /// </summary>
        [JsonProperty("ProgramItemList")]
        public ProgramItem[] ProgramItemList{ get; set; }

        /// <summary>
        /// ProgramItemList是否是空数组
        /// </summary>
        [JsonProperty("EmptyProgramItemList")]
        public bool? EmptyProgramItemList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProgramId", this.ProgramId);
            this.SetParamSimple(map, prefix + "ProgramName", this.ProgramName);
            this.SetParamSimple(map, prefix + "ProgramDesc", this.ProgramDesc);
            this.SetParamArrayObj(map, prefix + "ProgramItemList.", this.ProgramItemList);
            this.SetParamSimple(map, prefix + "EmptyProgramItemList", this.EmptyProgramItemList);
        }
    }
}

