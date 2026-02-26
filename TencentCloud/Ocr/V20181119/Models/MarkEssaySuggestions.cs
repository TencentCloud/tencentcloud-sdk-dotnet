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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MarkEssaySuggestions : AbstractModel
    {
        
        /// <summary>
        /// 作文批改序号
        /// </summary>
        [JsonProperty("ID")]
        public long? ID{ get; set; }

        /// <summary>
        /// 批改类型：主要包括：词汇、语句
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 子类型，基于Type返回二级类型
        /// 
        /// 词汇： 错别字、使用拼音、词语误用、词语冗余、词汇贫乏、多字/漏字
        /// 
        /// 语句：语法硬伤、逻辑问题、表达不佳、标点误用、优美句子
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// 原文内容
        /// </summary>
        [JsonProperty("Origin")]
        public string Origin{ get; set; }

        /// <summary>
        /// 批改后的内容
        /// </summary>
        [JsonProperty("Replace")]
        public string Replace{ get; set; }

        /// <summary>
        /// 点评内容
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

        /// <summary>
        /// array[][]二维数组，原文内容可能存在跨行的句子，会有多组坐标返回
        /// 
        /// 切图区域的4个角点坐标, 是个长度为8的数组
        /// 
        /// [0,1,2,3,4,5,6,7]
        /// 
        /// (0,1) 左上角坐标
        /// (2,3) 右上角坐标
        /// (4,5) 右下角坐标
        /// (6,7) 左下角坐标
        /// </summary>
        [JsonProperty("Positions")]
        public Positions[] Positions{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ID", this.ID);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "Origin", this.Origin);
            this.SetParamSimple(map, prefix + "Replace", this.Replace);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamArrayObj(map, prefix + "Positions.", this.Positions);
        }
    }
}

