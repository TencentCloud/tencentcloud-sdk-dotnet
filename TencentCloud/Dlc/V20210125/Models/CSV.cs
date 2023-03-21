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

namespace TencentCloud.Dlc.V20210125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CSV : AbstractModel
    {
        
        /// <summary>
        /// 压缩格式，["Snappy", "Gzip", "None"选一]。
        /// </summary>
        [JsonProperty("CodeCompress")]
        public string CodeCompress{ get; set; }

        /// <summary>
        /// CSV序列化及反序列化数据结构。
        /// </summary>
        [JsonProperty("CSVSerde")]
        public CSVSerde CSVSerde{ get; set; }

        /// <summary>
        /// 标题行，默认为0。
        /// </summary>
        [JsonProperty("HeadLines")]
        public long? HeadLines{ get; set; }

        /// <summary>
        /// 格式，默认值为CSV
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CodeCompress", this.CodeCompress);
            this.SetParamObj(map, prefix + "CSVSerde.", this.CSVSerde);
            this.SetParamSimple(map, prefix + "HeadLines", this.HeadLines);
            this.SetParamSimple(map, prefix + "Format", this.Format);
        }
    }
}

