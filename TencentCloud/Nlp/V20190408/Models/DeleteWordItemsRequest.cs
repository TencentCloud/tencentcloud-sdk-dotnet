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

namespace TencentCloud.Nlp.V20190408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteWordItemsRequest : AbstractModel
    {
        
        /// <summary>
        /// 待删除的词条集合。
        /// </summary>
        [JsonProperty("WordItems")]
        public WordItem[] WordItems{ get; set; }

        /// <summary>
        /// 自定义词库ID。
        /// </summary>
        [JsonProperty("DictId")]
        public string DictId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "WordItems.", this.WordItems);
            this.SetParamSimple(map, prefix + "DictId", this.DictId);
        }
    }
}

