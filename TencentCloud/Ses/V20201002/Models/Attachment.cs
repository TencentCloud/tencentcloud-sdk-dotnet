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

namespace TencentCloud.Ses.V20201002.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Attachment : AbstractModel
    {
        
        /// <summary>
        /// 附件名称，最大支持255个字符长度，不支持部分附件类型，详情请参考[附件类型](https://cloud.tencent.com/document/product/1288/51951)。
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// base64之后的附件内容，您可以发送的附件大小上限为4 MB。 注意：腾讯云api目前要求请求包大小不得超过8 MB。如果您要发送多个附件，那么这些附件的总大小不能超过8 MB。
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "Content", this.Content);
        }
    }
}

