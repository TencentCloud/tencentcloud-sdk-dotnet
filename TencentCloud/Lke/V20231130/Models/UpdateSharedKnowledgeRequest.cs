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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateSharedKnowledgeRequest : AbstractModel
    {
        
        /// <summary>
        /// 共享知识库业务ID
        /// </summary>
        [JsonProperty("KnowledgeBizId")]
        public string KnowledgeBizId{ get; set; }

        /// <summary>
        /// 共享知识库更新信息
        /// </summary>
        [JsonProperty("Info")]
        public KnowledgeUpdateInfo Info{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KnowledgeBizId", this.KnowledgeBizId);
            this.SetParamObj(map, prefix + "Info.", this.Info);
        }
    }
}

