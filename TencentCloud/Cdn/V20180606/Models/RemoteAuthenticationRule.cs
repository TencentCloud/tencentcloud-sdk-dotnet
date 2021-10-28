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

    public class RemoteAuthenticationRule : AbstractModel
    {
        
        /// <summary>
        /// 远程鉴权服务http url
        /// </summary>
        [JsonProperty("Server")]
        public string Server{ get; set; }

        /// <summary>
        /// 请求远程鉴权服务器的http方法；取值范围[get,post,head,all]; all 表示不限制请求方法；
        /// all: 不指定访问访问方法；
        /// </summary>
        [JsonProperty("AuthMethod")]
        public string AuthMethod{ get; set; }

        /// <summary>
        /// 规则类型：
        /// all：所有文件生效
        /// file：指定文件后缀生效
        /// directory：指定路径生效
        /// path：指定绝对路径生效
        /// </summary>
        [JsonProperty("RuleType")]
        public string RuleType{ get; set; }

        /// <summary>
        /// 对应类型下的匹配内容：
        /// all 时填充 *
        /// file 时填充后缀名，如 jpg、txt
        /// directory 时填充路径，如 /xxx/test
        /// path 时填充绝对路径，如 /xxx/test.html
        /// index 时填充 /
        /// </summary>
        [JsonProperty("RulePaths")]
        public string[] RulePaths{ get; set; }

        /// <summary>
        /// 请求远程鉴权服务器超时时间，单位毫秒；
        /// 取值范围：[1,30 000]
        /// </summary>
        [JsonProperty("AuthTimeout")]
        public long? AuthTimeout{ get; set; }

        /// <summary>
        /// 请求远程鉴权服务器超时后执行拦截或者放行；
        /// RETURN_200: 超时后放行；
        /// RETURN_403:超时返回403；
        /// </summary>
        [JsonProperty("AuthTimeoutAction")]
        public string AuthTimeoutAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Server", this.Server);
            this.SetParamSimple(map, prefix + "AuthMethod", this.AuthMethod);
            this.SetParamSimple(map, prefix + "RuleType", this.RuleType);
            this.SetParamArraySimple(map, prefix + "RulePaths.", this.RulePaths);
            this.SetParamSimple(map, prefix + "AuthTimeout", this.AuthTimeout);
            this.SetParamSimple(map, prefix + "AuthTimeoutAction", this.AuthTimeoutAction);
        }
    }
}

