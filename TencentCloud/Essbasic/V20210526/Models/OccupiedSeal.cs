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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OccupiedSeal : AbstractModel
    {
        
        /// <summary>
        /// <p>电子印章编号</p>
        /// </summary>
        [JsonProperty("SealId")]
        public string SealId{ get; set; }

        /// <summary>
        /// <p>电子印章名称</p>
        /// </summary>
        [JsonProperty("SealName")]
        public string SealName{ get; set; }

        /// <summary>
        /// <p>电子印章授权时间戳，单位秒</p>
        /// </summary>
        [JsonProperty("CreateOn")]
        public long? CreateOn{ get; set; }

        /// <summary>
        /// <p>电子印章授权人，电子签的UserId</p>
        /// </summary>
        [JsonProperty("Creator")]
        public string Creator{ get; set; }

        /// <summary>
        /// <p>电子印章策略Id</p>
        /// </summary>
        [JsonProperty("SealPolicyId")]
        public string SealPolicyId{ get; set; }

        /// <summary>
        /// <p>印章状态</p><p>枚举值：</p><ul><li>CHECKING： 待审核</li><li>CHECKING-SADM： 待超管审核</li><li>SUCCESS： 启用状态</li><li>FAIL： 审核拒绝</li><li>DISABLE： 已停用</li><li>STOPPED： 已终止</li><li>VOID： 已作废</li><li>INVALID： 已失效</li></ul>
        /// </summary>
        [JsonProperty("SealStatus")]
        public string SealStatus{ get; set; }

        /// <summary>
        /// <p>审核失败原因</p>
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// <p>印章图片url，5分钟内有效</p>
        /// </summary>
        [JsonProperty("Url")]
        public string Url{ get; set; }

        /// <summary>
        /// <p>电子印章类型 , 可选类型如下: </p><ul><li>**OFFICIAL**: (默认)公章</li><li>**CONTRACT**: 合同专用章;</li><li>**FINANCE**: 财务专用章;</li><li>**PERSONNEL**: 人事专用章</li><li>**INVOICE**: 发票专用章</li></ul>
        /// </summary>
        [JsonProperty("SealType")]
        public string SealType{ get; set; }

        /// <summary>
        /// <p>用印申请是否为永久授权</p>
        /// </summary>
        [JsonProperty("IsAllTime")]
        public bool? IsAllTime{ get; set; }

        /// <summary>
        /// <p>授权人列表</p>
        /// </summary>
        [JsonProperty("AuthorizedUsers")]
        public AuthorizedUser[] AuthorizedUsers{ get; set; }

        /// <summary>
        /// <p>印章的真实宽度，单位毫米</p>
        /// </summary>
        [JsonProperty("RealWidth")]
        public long? RealWidth{ get; set; }

        /// <summary>
        /// <p>印章的真实高度，单位毫米</p>
        /// </summary>
        [JsonProperty("RealHeight")]
        public long? RealHeight{ get; set; }

        /// <summary>
        /// <p>印章描述</p>
        /// </summary>
        [JsonProperty("SealDescription")]
        public string SealDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SealId", this.SealId);
            this.SetParamSimple(map, prefix + "SealName", this.SealName);
            this.SetParamSimple(map, prefix + "CreateOn", this.CreateOn);
            this.SetParamSimple(map, prefix + "Creator", this.Creator);
            this.SetParamSimple(map, prefix + "SealPolicyId", this.SealPolicyId);
            this.SetParamSimple(map, prefix + "SealStatus", this.SealStatus);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "Url", this.Url);
            this.SetParamSimple(map, prefix + "SealType", this.SealType);
            this.SetParamSimple(map, prefix + "IsAllTime", this.IsAllTime);
            this.SetParamArrayObj(map, prefix + "AuthorizedUsers.", this.AuthorizedUsers);
            this.SetParamSimple(map, prefix + "RealWidth", this.RealWidth);
            this.SetParamSimple(map, prefix + "RealHeight", this.RealHeight);
            this.SetParamSimple(map, prefix + "SealDescription", this.SealDescription);
        }
    }
}

