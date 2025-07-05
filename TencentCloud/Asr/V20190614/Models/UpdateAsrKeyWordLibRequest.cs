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

namespace TencentCloud.Asr.V20190614.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAsrKeyWordLibRequest : AbstractModel
    {
        
        /// <summary>
        /// 关键词表ID
        /// </summary>
        [JsonProperty("KeyWordLibId")]
        public string KeyWordLibId{ get; set; }

        /// <summary>
        /// 词表名称，长度在1-20之间
        /// 仅限中英文数字-_
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// - 词文件（纯文本文件）以行分隔 ，进行二进制base64编码
        /// - 格式要求：TXT 每行只有一个词，不满足格式则报错无法上传 
        /// - 每个词最多5个汉字或15个字符，单个词库最多不超过100个词
        /// - 此参数为空则只更新词表名称
        /// </summary>
        [JsonProperty("KeyWordFile")]
        public string KeyWordFile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyWordLibId", this.KeyWordLibId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "KeyWordFile", this.KeyWordFile);
        }
    }
}

