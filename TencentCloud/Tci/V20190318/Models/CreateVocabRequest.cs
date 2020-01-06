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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateVocabRequest : AbstractModel
    {
        
        /// <summary>
        /// 要添加词汇的词汇库名
        /// </summary>
        [JsonProperty("VocabLibName")]
        public string VocabLibName{ get; set; }

        /// <summary>
        /// 要添加的词汇列表
        /// </summary>
        [JsonProperty("VocabList")]
        public string[] VocabList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VocabLibName", this.VocabLibName);
            this.SetParamArraySimple(map, prefix + "VocabList.", this.VocabList);
        }
    }
}

