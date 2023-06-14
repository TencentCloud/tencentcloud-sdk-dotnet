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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtendAuthInfo : AbstractModel
    {
        
        /// <summary>
        /// 授权服务类型
        /// OPEN_SERVER_SIGN：开通企业静默签署
        /// OVERSEA_SIGN：企业与港澳台居民签署合同
        /// MOBILE_CHECK_APPROVER：使用手机号验证签署方身份
        /// PAGING_SEAL：骑缝章
        /// BATCH_SIGN：批量签署
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 授权服务名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 授权服务状态，ENABLE：开通
        /// DISABLE：未开通
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 授权人用户id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperatorUserId")]
        public string OperatorUserId{ get; set; }

        /// <summary>
        /// 授权时间戳，单位秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OperateOn")]
        public long? OperateOn{ get; set; }

        /// <summary>
        /// 被授权用户列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HasAuthUserList")]
        public HasAuthUser[] HasAuthUserList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "OperatorUserId", this.OperatorUserId);
            this.SetParamSimple(map, prefix + "OperateOn", this.OperateOn);
            this.SetParamArrayObj(map, prefix + "HasAuthUserList.", this.HasAuthUserList);
        }
    }
}

