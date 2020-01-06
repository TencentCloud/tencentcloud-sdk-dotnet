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

namespace TencentCloud.Cws.V20180312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifySiteAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID
        /// </summary>
        [JsonProperty("SiteId")]
        public ulong? SiteId{ get; set; }

        /// <summary>
        /// 站点名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 网站是否需要登录扫描：0-未知；-1-不需要；1-需要
        /// </summary>
        [JsonProperty("NeedLogin")]
        public long? NeedLogin{ get; set; }

        /// <summary>
        /// 登录后的cookie
        /// </summary>
        [JsonProperty("LoginCookie")]
        public string LoginCookie{ get; set; }

        /// <summary>
        /// 用于测试cookie是否有效的URL
        /// </summary>
        [JsonProperty("LoginCheckUrl")]
        public string LoginCheckUrl{ get; set; }

        /// <summary>
        /// 用于测试cookie是否有效的关键字
        /// </summary>
        [JsonProperty("LoginCheckKw")]
        public string LoginCheckKw{ get; set; }

        /// <summary>
        /// 禁止扫描器扫描的目录关键字
        /// </summary>
        [JsonProperty("ScanDisallow")]
        public string ScanDisallow{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SiteId", this.SiteId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NeedLogin", this.NeedLogin);
            this.SetParamSimple(map, prefix + "LoginCookie", this.LoginCookie);
            this.SetParamSimple(map, prefix + "LoginCheckUrl", this.LoginCheckUrl);
            this.SetParamSimple(map, prefix + "LoginCheckKw", this.LoginCheckKw);
            this.SetParamSimple(map, prefix + "ScanDisallow", this.ScanDisallow);
        }
    }
}

