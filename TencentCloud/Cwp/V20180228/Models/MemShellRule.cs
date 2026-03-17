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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MemShellRule : AbstractModel
    {
        
        /// <summary>
        /// 规则ID
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 客户端ID
        /// </summary>
        [JsonProperty("UuidHostips")]
        public UuidHostip[] UuidHostips{ get; set; }

        /// <summary>
        /// 逻辑运算符，0: 下面5个有效的正则逻辑与 1: 逻辑或
        /// </summary>
        [JsonProperty("LogicalSymbol")]
        public ulong? LogicalSymbol{ get; set; }

        /// <summary>
        /// 类名正则表达式，为空则不匹配
        /// </summary>
        [JsonProperty("ClassNameRegexp")]
        public string ClassNameRegexp{ get; set; }

        /// <summary>
        /// 父类名正则表达式，为空则不匹配
        /// </summary>
        [JsonProperty("SuperClassNameRegexp")]
        public string SuperClassNameRegexp{ get; set; }

        /// <summary>
        /// 继承的接口正则表达式，为空则不匹配
        /// </summary>
        [JsonProperty("InterfacesRegexp")]
        public string InterfacesRegexp{ get; set; }

        /// <summary>
        /// 注释正则表达式，为空则不匹配
        /// </summary>
        [JsonProperty("AnnotationsRegexp")]
        public string AnnotationsRegexp{ get; set; }

        /// <summary>
        /// 所属的类加载器正则表达式，为空则不匹配
        /// </summary>
        [JsonProperty("LoaderClassNameRegexp")]
        public string LoaderClassNameRegexp{ get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [JsonProperty("Operator")]
        public string Operator{ get; set; }

        /// <summary>
        /// 是否全局规则(是否对appid下所有主机有效， 0:单台uuid 1:全局，默认否)
        /// </summary>
        [JsonProperty("IsGlobal")]
        public ulong? IsGlobal{ get; set; }

        /// <summary>
        /// 状态 (0: 有效 1: 删除，2：无效（启用开关关闭）)
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 处理历史事件， 0:不处理 1:处理
        /// </summary>
        [JsonProperty("HandleHistory")]
        public ulong? HandleHistory{ get; set; }

        /// <summary>
        /// 批次id
        /// </summary>
        [JsonProperty("GroupID")]
        public string GroupID{ get; set; }

        /// <summary>
        /// 应用资产，描述服务器数量，全局时候为：全部服务器
        /// </summary>
        [JsonProperty("MachinesNums")]
        public string MachinesNums{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 源代码正则表达式，为空则不匹配
        /// </summary>
        [JsonProperty("CodeSourceRegexp")]
        public string CodeSourceRegexp{ get; set; }

        /// <summary>
        /// 调用栈正则表达式，为空则不匹配
        /// </summary>
        [JsonProperty("CallStackRegexp")]
        public string CallStackRegexp{ get; set; }

        /// <summary>
        /// 文件是否存在， 0:用户没选择规则时候的默认值，1：文件存在，2：文件不存在
        /// </summary>
        [JsonProperty("FileExist")]
        public ulong? FileExist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamArrayObj(map, prefix + "UuidHostips.", this.UuidHostips);
            this.SetParamSimple(map, prefix + "LogicalSymbol", this.LogicalSymbol);
            this.SetParamSimple(map, prefix + "ClassNameRegexp", this.ClassNameRegexp);
            this.SetParamSimple(map, prefix + "SuperClassNameRegexp", this.SuperClassNameRegexp);
            this.SetParamSimple(map, prefix + "InterfacesRegexp", this.InterfacesRegexp);
            this.SetParamSimple(map, prefix + "AnnotationsRegexp", this.AnnotationsRegexp);
            this.SetParamSimple(map, prefix + "LoaderClassNameRegexp", this.LoaderClassNameRegexp);
            this.SetParamSimple(map, prefix + "Operator", this.Operator);
            this.SetParamSimple(map, prefix + "IsGlobal", this.IsGlobal);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "HandleHistory", this.HandleHistory);
            this.SetParamSimple(map, prefix + "GroupID", this.GroupID);
            this.SetParamSimple(map, prefix + "MachinesNums", this.MachinesNums);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "CodeSourceRegexp", this.CodeSourceRegexp);
            this.SetParamSimple(map, prefix + "CallStackRegexp", this.CallStackRegexp);
            this.SetParamSimple(map, prefix + "FileExist", this.FileExist);
        }
    }
}

