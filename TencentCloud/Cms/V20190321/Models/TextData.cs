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
        /// </summary>
        [JsonProperty("EvilType")]
        public long? EvilType{ get; set; }

        /// <summary>
        /// 消息类公共相关参数
        /// </summary>
        [JsonProperty("Common")]
        public TextOutputComm Common{ get; set; }

        /// <summary>
        /// 返回的自定义词库结果
        /// </summary>
        [JsonProperty("CustomResult")]
        public CustomResult[] CustomResult{ get; set; }

        /// <summary>
        /// 返回的详细结果
        /// </summary>
        [JsonProperty("DetailResult")]
        public DetailResult[] DetailResult{ get; set; }

        /// <summary>
        /// 消息类ID信息
        /// </summary>
        [JsonProperty("ID")]
        public TextOutputID ID{ get; set; }

        /// <summary>
        /// 消息类输出结果
        /// </summary>
        [JsonProperty("Res")]
        public TextOutputRes Res{ get; set; }

        /// <summary>
        /// 账号风险检测结果
        /// </summary>
        [JsonProperty("RiskDetails")]
        public RiskDetails[] RiskDetails{ get; set; }

        /// <summary>
        /// 最终使用的BizType
        /// </summary>
        [JsonProperty("BizType")]
        public ulong? BizType{ get; set; }

        /// <summary>
        /// 恶意标签，Normal：正常，Polity：涉政，Porn：色情，Illegal：违法，Abuse：谩骂，Terror：暴恐，Ad：广告，Custom：自定义关键词
        /// </summary>
        [JsonProperty("EvilLabel")]
        public string EvilLabel{ get; set; }

        /// <summary>
        /// 命中的关键词
        /// </summary>
        [JsonProperty("Keywords")]
        public string[] Keywords{ get; set; }

        /// <summary>
        /// 命中的模型分值
        /// </summary>
        [JsonProperty("Score")]
        public ulong? Score{ get; set; }

        /// <summary>
        /// 建议值,Block：打击,Review：待复审,Normal：正常
        /// </summary>
        [JsonProperty("Suggestion")]
        public string Suggestion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EvilFlag", this.EvilFlag);
            this.SetParamSimple(map, prefix + "EvilType", this.EvilType);
            this.SetParamObj(map, prefix + "Common.", this.Common);
            this.SetParamArrayObj(map, prefix + "CustomResult.", this.CustomResult);
            this.SetParamArrayObj(map, prefix + "DetailResult.", this.DetailResult);
            this.SetParamObj(map, prefix + "ID.", this.ID);
            this.SetParamObj(map, prefix + "Res.", this.Res);
            this.SetParamArrayObj(map, prefix + "RiskDetails.", this.RiskDetails);
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "EvilLabel", this.EvilLabel);
            this.SetParamArraySimple(map, prefix + "Keywords.", this.Keywords);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "Suggestion", this.Suggestion);
        }
    }
}

