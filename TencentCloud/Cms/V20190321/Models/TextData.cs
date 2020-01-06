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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TextData : AbstractModel
    {
        
        /// <summary>
        /// 是否恶意 0：正常 1：可疑
        /// </summary>
        [JsonProperty("EvilFlag")]
        public long? EvilFlag{ get; set; }

        /// <summary>
        /// 恶意类型
        /// 100：正常
        /// 20001：政治
        /// 20002：色情 
        /// 20006：涉毒违法
        /// 20007：谩骂
        /// 20105：广告引流 
        /// 24001：暴恐
        /// 21000：综合
        /// </summary>
        [JsonProperty("EvilType")]
        public long? EvilType{ get; set; }

        /// <summary>
        /// 命中的关键词
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EvilFlag", this.EvilFlag);
            this.SetParamSimple(map, prefix + "EvilType", this.EvilType);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
        }
    }
}

