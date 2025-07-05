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

namespace TencentCloud.Ivld.V20210903.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateCustomPersonRequest : AbstractModel
    {
        
        /// <summary>
        /// 待更新的自定义人物Id
        /// </summary>
        [JsonProperty("PersonId")]
        public string PersonId{ get; set; }

        /// <summary>
        /// 更新后的自定义人物名称，如为空则不更新
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 更新后的自定义人物简介，如为空则不更新
        /// </summary>
        [JsonProperty("BasicInfo")]
        public string BasicInfo{ get; set; }

        /// <summary>
        /// 更新后的分类信息，如为空则不更新
        /// </summary>
        [JsonProperty("CategoryId")]
        public string CategoryId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PersonId", this.PersonId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "BasicInfo", this.BasicInfo);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
        }
    }
}

