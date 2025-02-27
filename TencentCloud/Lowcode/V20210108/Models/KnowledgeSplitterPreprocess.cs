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

    public class KnowledgeSplitterPreprocess : AbstractModel
    {
        
        /// <summary>
        /// 在对文件拆分时，配置是否将 Title 追加到切分后的段落后面一并 Embedding。取值如下所示：
        /// false：不追加。
        /// true：将段落 Title 追加到切分后的段落。
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppendTitleToChunk")]
        public bool? AppendTitleToChunk{ get; set; }

        /// <summary>
        /// 在对文件拆分时，配置是否将关键字 keywords 追加到切分后的段落一并 Embedding。取值如下所示：
        /// false：不追加。
        /// true：将全文的 keywords 追加到切分后的段落。
        /// 
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppendKeywordsToChunk")]
        public bool? AppendKeywordsToChunk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppendTitleToChunk", this.AppendTitleToChunk);
            this.SetParamSimple(map, prefix + "AppendKeywordsToChunk", this.AppendKeywordsToChunk);
        }
    }
}

