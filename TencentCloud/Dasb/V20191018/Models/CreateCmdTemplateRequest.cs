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

namespace TencentCloud.Dasb.V20191018.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCmdTemplateRequest : AbstractModel
    {
        
        /// <summary>
        /// 模板名，最大长度32字符，不能包含空白字符
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 命令列表，\n分隔，最大长度32768字节
        /// </summary>
        [JsonProperty("CmdList")]
        public string CmdList{ get; set; }

        /// <summary>
        /// 标识cmdlist字段前端是否为base64加密传值.
        /// 0:表示非base64加密
        /// 1:表示是base64加密
        /// </summary>
        [JsonProperty("Encoding")]
        public ulong? Encoding{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "CmdList", this.CmdList);
            this.SetParamSimple(map, prefix + "Encoding", this.Encoding);
        }
    }
}

