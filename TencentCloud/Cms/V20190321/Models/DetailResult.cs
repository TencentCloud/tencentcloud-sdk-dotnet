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

namespace TencentCloud.Cms.V20190321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DetailResult : AbstractModel
    {
        
        /// <summary>
        /// 该标签下命中的关键词
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// 恶意类型
        /// 100：正常
        /// 20001：政治
        /// 20002：色情 
        /// 20006：涉毒违法
        /// 20007：谩骂
        /// 20105：广告引流 
        /// 24001：暴恐
        /// </summary>
        [JsonProperty("EvilType")]
        public ulong? EvilType{ get; set; }

        /// <summary>
        /// 该标签模型命中的分值
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// 恶意标签，Normal：正常，Polity：涉政，Porn：色情，Illegal：违法，Abuse：谩骂，Terror：暴恐，Ad：广告，Custom：自定义关键词
        /// </summary>
        [JsonProperty("EvilLabel")]
        public string EvilLabel{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamSimple(map, prefix + "EvilType", this.EvilType);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "EvilLabel", this.EvilLabel);
        }
    }
}

