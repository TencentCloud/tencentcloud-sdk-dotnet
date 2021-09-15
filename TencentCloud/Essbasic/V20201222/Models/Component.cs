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

namespace TencentCloud.Essbasic.V20201222.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Component : AbstractModel
    {
        
        /// <summary>
        /// 控件编号
        /// 
        /// 注：
        /// 当GenerateMode=3时，通过"^"来决定是否使用关键字整词匹配能力。
        /// 例：
        /// 当GenerateMode=3时，如果传入关键字"^甲方签署^"，则会在PDF文件中有且仅有"甲方签署"关键字的地方进行对应操作。
        /// 如传入的关键字为"甲方签署"，则PDF文件中每个出现关键字的位置都会执行相应操作。
        /// </summary>
        [JsonProperty("ComponentId")]
        public string ComponentId{ get; set; }

        /// <summary>
        /// 如果是Component控件类型，则可选的字段为：
        /// TEXT - 普通文本控件；
        /// DATE - 普通日期控件；
        /// SELECT- 勾选框控件；
        /// 如果是SignComponent控件类型，则可选的字段为
        /// SIGN_SEAL- 签署印章控件；
        /// SIGN_DATE- 签署日期控件；
        /// SIGN_SIGNATURE - 用户签名控件；
        /// </summary>
        [JsonProperty("ComponentType")]
        public string ComponentType{ get; set; }

        /// <summary>
        /// 控件名称
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }

        /// <summary>
        /// 定义控件是否为必填项，默认为false
        /// </summary>
        [JsonProperty("ComponentRequired")]
        public bool? ComponentRequired{ get; set; }

        /// <summary>
        /// 控件所属文件的序号 (模板中的resourceId排列序号)
        /// </summary>
        [JsonProperty("FileIndex")]
        public long? FileIndex{ get; set; }

        /// <summary>
        /// 控件生成的方式：
        /// 0 - 普通控件
        /// 1 - 表单域
        /// 2 - html 控件
        /// 3 - 关键字
        /// </summary>
        [JsonProperty("GenerateMode")]
        public long? GenerateMode{ get; set; }

        /// <summary>
        /// 参数控件宽度，单位px
        /// </summary>
        [JsonProperty("ComponentWidth")]
        public float? ComponentWidth{ get; set; }

        /// <summary>
        /// 参数控件高度，单位px
        /// </summary>
        [JsonProperty("ComponentHeight")]
        public float? ComponentHeight{ get; set; }

        /// <summary>
        /// 参数控件所在页码
        /// </summary>
        [JsonProperty("ComponentPage")]
        public long? ComponentPage{ get; set; }

        /// <summary>
        /// 参数控件X位置，单位px
        /// </summary>
        [JsonProperty("ComponentPosX")]
        public float? ComponentPosX{ get; set; }

        /// <summary>
        /// 参数控件Y位置，单位px
        /// </summary>
        [JsonProperty("ComponentPosY")]
        public float? ComponentPosY{ get; set; }

        /// <summary>
        /// 参数控件样式
        /// </summary>
        [JsonProperty("ComponentExtra")]
        public string ComponentExtra{ get; set; }

        /// <summary>
        /// 印章ID，如果是手写签名则为jpg或png格式的base64图片
        /// 
        /// SIGN_SEAL控件,可以用ORG_DEFAULT_SEAL表示主企业的默认印章
        /// SIGN_SEAL控件,可以用SUBORG_DEFAULT_SEAL表示子企业的默认印章
        /// SIGN_SEAL控件,可以用USER_DEFAULT_SEAL表示个人默认印章
        /// </summary>
        [JsonProperty("ComponentValue")]
        public string ComponentValue{ get; set; }

        /// <summary>
        /// 如果是SIGN_SEAL类型的签署控件, 参数标识H5签署界面是否在该签署区上进行放置展示, 1为放置,其他为不放置
        /// </summary>
        [JsonProperty("SealOperate")]
        public long? SealOperate{ get; set; }

        /// <summary>
        /// 不同GenerateMode对应的额外信息
        /// </summary>
        [JsonProperty("GenerateExtra")]
        public string GenerateExtra{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComponentId", this.ComponentId);
            this.SetParamSimple(map, prefix + "ComponentType", this.ComponentType);
            this.SetParamSimple(map, prefix + "ComponentName", this.ComponentName);
            this.SetParamSimple(map, prefix + "ComponentRequired", this.ComponentRequired);
            this.SetParamSimple(map, prefix + "FileIndex", this.FileIndex);
            this.SetParamSimple(map, prefix + "GenerateMode", this.GenerateMode);
            this.SetParamSimple(map, prefix + "ComponentWidth", this.ComponentWidth);
            this.SetParamSimple(map, prefix + "ComponentHeight", this.ComponentHeight);
            this.SetParamSimple(map, prefix + "ComponentPage", this.ComponentPage);
            this.SetParamSimple(map, prefix + "ComponentPosX", this.ComponentPosX);
            this.SetParamSimple(map, prefix + "ComponentPosY", this.ComponentPosY);
            this.SetParamSimple(map, prefix + "ComponentExtra", this.ComponentExtra);
            this.SetParamSimple(map, prefix + "ComponentValue", this.ComponentValue);
            this.SetParamSimple(map, prefix + "SealOperate", this.SealOperate);
            this.SetParamSimple(map, prefix + "GenerateExtra", this.GenerateExtra);
        }
    }
}

