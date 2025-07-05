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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyChangePwdTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 改密任务id
        /// </summary>
        [JsonProperty("OperationId")]
        public string OperationId{ get; set; }

        /// <summary>
        /// 改密资产id列表
        /// </summary>
        [JsonProperty("DeviceIdSet")]
        public ulong?[] DeviceIdSet{ get; set; }

        /// <summary>
        /// 改密资产的账号列表
        /// </summary>
        [JsonProperty("AccountSet")]
        public string[] AccountSet{ get; set; }

        /// <summary>
        /// 修改类型：1：修改任务信息  2：关联任务资产账号
        /// </summary>
        [JsonProperty("ModifyType")]
        public ulong? ModifyType{ get; set; }

        /// <summary>
        /// 改密方式。1：使用执行账号修改密码；2：修改自身密码
        /// </summary>
        [JsonProperty("ChangeMethod")]
        public long? ChangeMethod{ get; set; }

        /// <summary>
        /// 密码生成方式。 1:自动生成相同密码 2:自动生成不同密码 3:手动指定相同密码
        /// </summary>
        [JsonProperty("AuthGenerationStrategy")]
        public long? AuthGenerationStrategy{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("TaskName")]
        public string TaskName{ get; set; }

        /// <summary>
        /// 所属部门ID，"1,2,3"
        /// </summary>
        [JsonProperty("DepartmentId")]
        public string DepartmentId{ get; set; }

        /// <summary>
        /// 任务的执行账号	
        /// </summary>
        [JsonProperty("RunAccount")]
        public string RunAccount{ get; set; }

        /// <summary>
        /// 密码，手动指定密码时必传。
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 密码限制长度，自动生成密码必传。	
        /// </summary>
        [JsonProperty("PasswordLength")]
        public long? PasswordLength{ get; set; }

        /// <summary>
        /// 密码包含小写字母，0：否，1：是。
        /// </summary>
        [JsonProperty("SmallLetter")]
        public long? SmallLetter{ get; set; }

        /// <summary>
        /// 密码包含大写字母，0：否，1：是。
        /// </summary>
        [JsonProperty("BigLetter")]
        public long? BigLetter{ get; set; }

        /// <summary>
        /// 密码包含数字，0：否，1：是。
        /// </summary>
        [JsonProperty("Digit")]
        public long? Digit{ get; set; }

        /// <summary>
        /// 密码包含的特殊字符（base64编码），包含：^[-_#();%~!+=]*$
        /// </summary>
        [JsonProperty("Symbol")]
        public string Symbol{ get; set; }

        /// <summary>
        /// 改密完成通知。0：不通知 1：通知
        /// </summary>
        [JsonProperty("CompleteNotify")]
        public long? CompleteNotify{ get; set; }

        /// <summary>
        /// 通知邮箱
        /// </summary>
        [JsonProperty("NotifyEmails")]
        public string[] NotifyEmails{ get; set; }

        /// <summary>
        /// 加密压缩文件密码
        /// </summary>
        [JsonProperty("FilePassword")]
        public string FilePassword{ get; set; }

        /// <summary>
        /// 任务类型， 4：手工执行  5：周期自动执行
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 周期任务周期，单位天（大于等于 1，小于等于 365）
        /// </summary>
        [JsonProperty("Period")]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 周期任务首次执行时间
        /// </summary>
        [JsonProperty("FirstTime")]
        public string FirstTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OperationId", this.OperationId);
            this.SetParamArraySimple(map, prefix + "DeviceIdSet.", this.DeviceIdSet);
            this.SetParamArraySimple(map, prefix + "AccountSet.", this.AccountSet);
            this.SetParamSimple(map, prefix + "ModifyType", this.ModifyType);
            this.SetParamSimple(map, prefix + "ChangeMethod", this.ChangeMethod);
            this.SetParamSimple(map, prefix + "AuthGenerationStrategy", this.AuthGenerationStrategy);
            this.SetParamSimple(map, prefix + "TaskName", this.TaskName);
            this.SetParamSimple(map, prefix + "DepartmentId", this.DepartmentId);
            this.SetParamSimple(map, prefix + "RunAccount", this.RunAccount);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "PasswordLength", this.PasswordLength);
            this.SetParamSimple(map, prefix + "SmallLetter", this.SmallLetter);
            this.SetParamSimple(map, prefix + "BigLetter", this.BigLetter);
            this.SetParamSimple(map, prefix + "Digit", this.Digit);
            this.SetParamSimple(map, prefix + "Symbol", this.Symbol);
            this.SetParamSimple(map, prefix + "CompleteNotify", this.CompleteNotify);
            this.SetParamArraySimple(map, prefix + "NotifyEmails.", this.NotifyEmails);
            this.SetParamSimple(map, prefix + "FilePassword", this.FilePassword);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "FirstTime", this.FirstTime);
        }
    }
}

