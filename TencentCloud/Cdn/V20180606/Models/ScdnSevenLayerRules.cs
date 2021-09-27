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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScdnSevenLayerRules : AbstractModel
    {
        
        /// <summary>
        /// 区分大小写
        /// </summary>
        [JsonProperty("CaseSensitive")]
        public bool? CaseSensitive{ get; set; }

        /// <summary>
        /// 规则类型：
        /// protocol：协议，填写 HTTP/HTTPS
        /// method：请求方法，支持 HEAD、GET、POST、PUT、OPTIONS、TRACE、DELETE、PATCH、CONNECT
        /// all：域名 匹配内容固定为"*",不可编辑修改
        /// ip：IP 填写 CIDR 表达式
        /// directory：路径，以/开头，支持目录和具体路径，128字符以内
        /// index：首页 默认固定值：/;/index.html,不可编辑修改
        /// path：文件全路径，资源地址，如/acb/test.png，支持通配符，如/abc/*.jpg
        /// file：文件扩展名，填写具体扩展名，如 jpg;png;css
        /// param：请求参数，填写具体 value 值，512字符以内
        /// referer：Referer，填写具体 value 值，512字符以内
        /// cookie：Cookie，填写具体 value 值，512字符以内
        /// user-agent：User-Agent，填写具体 value 值，512字符以内
        /// head：自定义请求头，填写具体value值，512字符以内；内容为空或者不存在时，无匹配内容输入框，填写匹配参数即可
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 逻辑操作符，取值 ：
        /// 不包含：exclude, 
        /// 包含：include, 
        /// 不等于：notequal, 
        /// 等于：equal, 
        /// 前缀匹配：matching
        /// 内容为空或不存在：null
        /// </summary>
        [JsonProperty("LogicOperator")]
        public string LogicOperator{ get; set; }

        /// <summary>
        /// 规则值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleValue")]
        public string[] RuleValue{ get; set; }

        /// <summary>
        /// 匹配参数，只有请求参数、Cookie、自定义请求头 有值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RuleParam")]
        public string RuleParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CaseSensitive", this.CaseSensitive);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamSimple(map, prefix + "LogicOperator", this.LogicOperator);
            this.SetParamArraySimple(map, prefix + "RuleValue.", this.RuleValue);
            this.SetParamSimple(map, prefix + "RuleParam", this.RuleParam);
        }
    }
}

