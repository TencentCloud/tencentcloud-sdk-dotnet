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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QALifecycle : AbstractModel
    {
        
        /// <summary>
        /// <p>创建时间（Unix 秒）</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>过期策略（有效时间与超过有效时间后的行为）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpirationPolicy")]
        public ExpirationPolicy ExpirationPolicy{ get; set; }

        /// <summary>
        /// <p>状态：1=待校验，2=未采纳，3=导入失败，4=审核中，5=审核失败，6=学习中，7=学习失败，8=导入完成，9=已过期，10=超量失效，11=超量失效恢复中，12=人工申诉中，13=人工申诉失败<table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>QA_STATUS_UNKNOWN</td><td>0</td><td></td></tr><tr><td>QA_STATUS_PENDING_VERIFY</td><td>1</td><td>待校验</td></tr><tr><td>QA_STATUS_NOT_ACCEPTED</td><td>2</td><td>未采纳</td></tr><tr><td>QA_STATUS_IMPORT_FAIL</td><td>3</td><td>导入失败</td></tr><tr><td>QA_STATUS_AUDITING</td><td>4</td><td>审核中</td></tr><tr><td>QA_STATUS_AUDIT_FAIL</td><td>5</td><td>审核失败</td></tr><tr><td>QA_STATUS_LEARNING</td><td>6</td><td>学习中</td></tr><tr><td>QA_STATUS_LEARN_FAIL</td><td>7</td><td>学习失败</td></tr><tr><td>QA_STATUS_IMPORTED</td><td>8</td><td>导入完成</td></tr><tr><td>QA_STATUS_EXPIRED</td><td>9</td><td>已过期</td></tr><tr><td>QA_STATUS_QUOTA_INVALID</td><td>10</td><td>超量失效</td></tr><tr><td>QA_STATUS_QUOTA_RECOVERING</td><td>11</td><td>超量失效恢复中</td></tr><tr><td>QA_STATUS_MANUAL_APPEALING</td><td>12</td><td>人工申诉中</td></tr><tr><td>QA_STATUS_MANUAL_APPEAL_FAIL</td><td>13</td><td>人工申诉失败</td></tr></tbody></table></p>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// <p>状态描述</p>
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// <p>状态附加信息</p>
        /// </summary>
        [JsonProperty("StatusMessage")]
        public string StatusMessage{ get; set; }

        /// <summary>
        /// <p>更新时间（Unix 秒）</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamObj(map, prefix + "ExpirationPolicy.", this.ExpirationPolicy);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "StatusMessage", this.StatusMessage);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

