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
        ///   AUTO_SIGN             企业静默签（自动签署）
        ///   OVERSEA_SIGN          企业与港澳台居民*签署合同
        ///   MOBILE_CHECK_APPROVER 使用手机号验证签署方身份
        ///   PAGING_SEAL           骑缝章
        ///   DOWNLOAD_FLOW         授权渠道下载合同 
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 扩展服务名称 
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 服务状态 
        /// ENABLE 开启 
        /// DISABLE 关闭
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 最近操作人openid（经办人openid）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperatorOpenId")]
        public string OperatorOpenId{ get; set; }

        /// <summary>
        /// 最近操作时间
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

