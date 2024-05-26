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

    public class ChangePwdTaskInfo : AbstractModel
    {
        
        /// <summary>
        /// id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 任务id
        /// </summary>
        [JsonProperty("OperationId")]
        public string OperationId{ get; set; }

        /// <summary>
        /// 任务名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 所属部门信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Department")]
        public Department Department{ get; set; }

        /// <summary>
        /// 改密方式。1：使用执行账号。2：修改自身密码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChangeMethod")]
        public ulong? ChangeMethod{ get; set; }

        /// <summary>
        /// 执行账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RunAccount")]
        public string RunAccount{ get; set; }

        /// <summary>
        /// 密码生成策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AuthGenerationStrategy")]
        public ulong? AuthGenerationStrategy{ get; set; }

        /// <summary>
        /// 密码长度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PasswordLength")]
        public ulong? PasswordLength{ get; set; }

        /// <summary>
        /// 包含小写字母
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SmallLetter")]
        public ulong? SmallLetter{ get; set; }

        /// <summary>
        /// 包含大写字母
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BigLetter")]
        public ulong? BigLetter{ get; set; }

        /// <summary>
        /// 包含数字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Digit")]
        public ulong? Digit{ get; set; }

        /// <summary>
        /// 包含的特殊字符，base64
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Symbol")]
        public string Symbol{ get; set; }

        /// <summary>
        /// 改密完成通知。0-通知，1-不通知
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CompleteNotify")]
        public ulong? CompleteNotify{ get; set; }

        /// <summary>
        /// 通知人邮箱
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NotifyEmails")]
        public string[] NotifyEmails{ get; set; }

        /// <summary>
        /// 加密附件密码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilePassword")]
        public string FilePassword{ get; set; }

        /// <summary>
        /// 需要改密的账户
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountSet")]
        public string[] AccountSet{ get; set; }

        /// <summary>
        /// 需要改密的主机
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeviceSet")]
        public Device[] DeviceSet{ get; set; }

        /// <summary>
        /// 任务类型：4手动，5自动
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 周期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 首次执行时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }

        /// <summary>
        /// 下次执行时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NextTime")]
        public string NextTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "OperationId", this.OperationId);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamObj(map, prefix + "Department.", this.Department);
            this.SetParamSimple(map, prefix + "ChangeMethod", this.ChangeMethod);
            this.SetParamSimple(map, prefix + "RunAccount", this.RunAccount);
            this.SetParamSimple(map, prefix + "AuthGenerationStrategy", this.AuthGenerationStrategy);
            this.SetParamSimple(map, prefix + "PasswordLength", this.PasswordLength);
            this.SetParamSimple(map, prefix + "SmallLetter", this.SmallLetter);
            this.SetParamSimple(map, prefix + "BigLetter", this.BigLetter);
            this.SetParamSimple(map, prefix + "Digit", this.Digit);
            this.SetParamSimple(map, prefix + "Symbol", this.Symbol);
            this.SetParamSimple(map, prefix + "CompleteNotify", this.CompleteNotify);
            this.SetParamArraySimple(map, prefix + "NotifyEmails.", this.NotifyEmails);
            this.SetParamSimple(map, prefix + "FilePassword", this.FilePassword);
            this.SetParamArraySimple(map, prefix + "AccountSet.", this.AccountSet);
            this.SetParamArrayObj(map, prefix + "DeviceSet.", this.DeviceSet);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
            this.SetParamSimple(map, prefix + "NextTime", this.NextTime);
        }
    }
}

