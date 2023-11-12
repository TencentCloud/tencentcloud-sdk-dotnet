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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtentServiceAuthInfo : AbstractModel
    {
        
        /// <summary>
        /// 扩展服务类型
        /// <ul>
        /// <li>AUTO_SIGN             企业自动签（自动签署）</li>
        /// <li>  OVERSEA_SIGN          企业与港澳台居民*签署合同</li>
        /// <li>  MOBILE_CHECK_APPROVER 使用手机号验证签署方身份</li>
        /// <li> PAGING_SEAL           骑缝章</li>
        /// <li> DOWNLOAD_FLOW         授权渠道下载合同 </li>
        /// <li>AGE_LIMIT_EXPANSION 拓宽签署方年龄限制</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 扩展服务名称 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 扩展服务的开通状态
        /// **ENABLE**：开通 
        /// **DISABLE**：未开通	
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 操作扩展服务的操作人第三方应用平台的用户openid
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperatorOpenId")]
        public string OperatorOpenId{ get; set; }

        /// <summary>
        /// 扩展服务的操作时间，格式为Unix标准时间戳（秒）。	
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperateOn")]
        public long? OperateOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OperatorOpenId", this.OperatorOpenId);
            this.SetParamSimple(map, prefix + "OperateOn", this.OperateOn);
        }
    }
}

