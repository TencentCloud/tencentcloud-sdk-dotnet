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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SimilarQuestionModify : AbstractModel
    {
        
        /// <summary>
        /// 需要添加的相似问(内容)列表
        /// </summary>
        [JsonProperty("AddQuestions")]
        public string[] AddQuestions{ get; set; }

        /// <summary>
        /// 需要更新的相似问列表
        /// </summary>
        [JsonProperty("UpdateQuestions")]
        public SimilarQuestion[] UpdateQuestions{ get; set; }

        /// <summary>
        /// 需要删除的相似问列表
        /// </summary>
        [JsonProperty("DeleteQuestions")]
        public SimilarQuestion[] DeleteQuestions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AddQuestions.", this.AddQuestions);
            this.SetParamArrayObj(map, prefix + "UpdateQuestions.", this.UpdateQuestions);
            this.SetParamArrayObj(map, prefix + "DeleteQuestions.", this.DeleteQuestions);
        }
    }
}

