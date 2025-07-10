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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAppRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID
        /// </summary>
        [JsonProperty("AppBizId")]
        public string AppBizId{ get; set; }

        /// <summary>
        /// 应用类型；knowledge_qa-知识问答管理；summary-知识摘要；classify-知识标签提取
        /// </summary>
        [JsonProperty("AppType")]
        public string AppType{ get; set; }

        /// <summary>
        /// 应用基础配置
        /// </summary>
        [JsonProperty("BaseConfig")]
        public BaseConfig BaseConfig{ get; set; }

        /// <summary>
        /// 应用配置
        /// </summary>
        [JsonProperty("AppConfig")]
        public AppConfig AppConfig{ get; set; }

        /// <summary>
        /// 登录用户子账号(集成商模式必填)	
        /// </summary>
        [JsonProperty("LoginSubAccountUin")]
        public string LoginSubAccountUin{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppBizId", this.AppBizId);
            this.SetParamSimple(map, prefix + "AppType", this.AppType);
            this.SetParamObj(map, prefix + "BaseConfig.", this.BaseConfig);
            this.SetParamObj(map, prefix + "AppConfig.", this.AppConfig);
            this.SetParamSimple(map, prefix + "LoginSubAccountUin", this.LoginSubAccountUin);
        }
    }
}

