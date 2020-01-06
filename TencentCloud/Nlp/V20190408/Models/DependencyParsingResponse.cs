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

    public class DependencyParsingResponse : AbstractModel
    {
        
        /// <summary>
        /// 句法依存分析结果，其中句法依存关系的类型包括：
        /// <li>主谓关系，eg: 我送她一束花 (我 <-- 送)
        /// <li>动宾关系，eg: 我送她一束花 (送 --> 花)
        /// <li>间宾关系，eg: 我送她一束花 (送 --> 她)
        /// <li>前置宾语，eg: 他什么书都读 (书 <-- 读)
        /// <li>兼语，eg: 他请我吃饭 (请 --> 我)
        /// <li>定中关系，eg: 红苹果 (红 <-- 苹果)
        /// <li>状中结构，eg: 非常美丽 (非常 <-- 美丽)
        /// <li>动补结构，eg: 做完了作业 (做 --> 完)
        /// <li>并列关系，eg: 大山和大海 (大山 --> 大海)
        /// <li>介宾关系，eg: 在贸易区内 (在 --> 内)
        /// <li>左附加关系，eg: 大山和大海 (和 <-- 大海)
        /// <li>右附加关系，eg: 孩子们 (孩子 --> 们)
        /// <li>独立结构，eg: 两个单句在结构上彼此独立
        /// <li>标点符号，eg: 。
        /// <li>核心关系，eg: 整个句子的核心
        /// </summary>
        [JsonProperty("DpTokens")]
        public DpToken[] DpTokens{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "DpTokens.", this.DpTokens);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

