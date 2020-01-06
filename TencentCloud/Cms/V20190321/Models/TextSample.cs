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

    public class TextSample : AbstractModel
    {
        
        /// <summary>
        /// 处理错误码
        /// </summary>
        [JsonProperty("Code")]
        public long? Code{ get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        [JsonProperty("CreatedAt")]
        public ulong? CreatedAt{ get; set; }

        /// <summary>
        /// 恶意类型
        /// 100：正常
        /// 20001：政治
        /// 20002：色情 
        /// 20006：涉毒违法
        /// 20007：谩骂 
        /// 20105：广告引流 
        /// 24001：暴恐
        /// 20004/21000：综合
        /// </summary>
        [JsonProperty("EvilType")]
        public ulong? EvilType{ get; set; }

        /// <summary>
        /// 唯一标识
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 样本类型
        /// 1：黑库
        /// 2：白库
        /// </summary>
        [JsonProperty("Label")]
        public ulong? Label{ get; set; }

        /// <summary>
        /// 任务状态
        /// 1：已完成
        /// 2：处理中
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "EvilType", this.EvilType);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Label", this.Label);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}

