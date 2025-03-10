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

namespace TencentCloud.Lowcode.V20210108.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeKnowledgeDocumentSetDetailRequest : AbstractModel
    {
        
        /// <summary>
        /// 环境ID
        /// </summary>
        [JsonProperty("EnvId")]
        public string EnvId{ get; set; }

        /// <summary>
        /// 知识库标识
        /// </summary>
        [JsonProperty("CollectionView")]
        public string CollectionView{ get; set; }

        /// <summary>
        /// 文件名
        /// </summary>
        [JsonProperty("DocumentSetName")]
        public string DocumentSetName{ get; set; }

        /// <summary>
        /// 文件id
        /// </summary>
        [JsonProperty("DocumentSetId")]
        public string DocumentSetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EnvId", this.EnvId);
            this.SetParamSimple(map, prefix + "CollectionView", this.CollectionView);
            this.SetParamSimple(map, prefix + "DocumentSetName", this.DocumentSetName);
            this.SetParamSimple(map, prefix + "DocumentSetId", this.DocumentSetId);
        }
    }
}

